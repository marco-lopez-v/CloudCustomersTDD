using CloudCustomersTDD.API.Models;
using CloudCustomersTDD.API.Services;
using CloudCustomersTDD.UnitTests.Fixtures;
using CloudCustomersTDD.UnitTests.Helpers;
using Moq;
using Moq.Protected;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CloudCustomersTDD.UnitTests.Systems.Services;

public class TestUsersService
{
    [Fact]
    public async Task GetAllUsers_WhenCalled_InvokesHttpGetRequest()
    {
        // Arrange
        var expectedResponse = UsersFixture.GetTestUsers();
        var handlerMock = MockHttpMessageHandler<User>.SetupBasicGetResourceList(expectedResponse);
        var httpClient = new HttpClient(handlerMock.Object);

        var sut = new UsersService(httpClient;

        // Act

        await sut.GetAllUsers();

        // Assert
        handlerMock
            .Protected()
            .Verify(
            "SendAsync",
            Times.Exactly(1),
            ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get),
            ItExpr.IsAny<CancellationToken>()
        );
    }
}
