using Api.Controllers;
using Application.Dto;
using Application.Features.Accounts.GetAccounts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ApiTests;

public class AccountsControllerTests
{
    private const string Name1 = "Account 1";
    private const string Name2 = "Account 2";
    private static readonly Guid Guid1 = new("925d93fc-a8b0-475b-b3a1-a1db8d11ae5b");
    private static readonly Guid Guid2 = new("925d93fc-a8b0-475b-b3a1-a1db8d11ae51");
    private readonly AccountsController _controller;

    private readonly Mock<IMediator> _mediatorMock;

    public AccountsControllerTests()
    {
        _mediatorMock = new Mock<IMediator>();
        _controller = new AccountsController(_mediatorMock.Object);
    }

    [Fact]
    public async Task Get_ReturnsOkResult_WithAccountsList()
    {
        // Arrange
        var accounts = new List<Account>
        {
            new() { Id = Guid1, Name = Name1 },
            new() { Id = Guid2, Name = Name2 }
        };

        _mediatorMock
            .Setup(m => m.Send(It.IsAny<GetAccountsQuery>(), default))
            .ReturnsAsync(accounts);

        // Act
        var result = await _controller.Get();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedAccounts = Assert.IsType<List<Account>>(okResult.Value);
        Assert.Equal(2, returnedAccounts.Count);
        Assert.Equal(Name1, returnedAccounts[0].Name);
        Assert.Equal(Guid1, returnedAccounts[0].Id);
    }

    [Fact]
    public async Task Get_ReturnsEmptyList_WhenNoAccountsFound()
    {
        // Arrange
        _mediatorMock
            .Setup(m => m.Send(It.IsAny<GetAccountsQuery>(), default))
            .ReturnsAsync((List<Account>) []);

        // Act
        var result = await _controller.Get();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedAccounts = Assert.IsType<List<Account>>(okResult.Value);
        Assert.Empty(returnedAccounts);
    }
}