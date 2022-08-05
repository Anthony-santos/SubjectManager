using Api.Controllers;
using Api.Models;
using Api.Repositories;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace SubjectManager.Test.Systems.Controllers;

public class TestSubjectController
{
    [Fact]
    public void Get_OnSuccess_InvokesUsersRepositoryExactlyOnce()
    {
        // Arrange
        var mockSubjectRepository = new Mock<ISubjectRepository>();

        mockSubjectRepository
            .Setup(resp => resp.GetAllSubjects())
            .Returns(new List<Subject>());

        var sut = new SubjectController(mockSubjectRepository.Object);

        // Act
        var result = sut.GetAll();

        // Assert
        mockSubjectRepository.Verify(
            s => s.GetAllSubjects(),
            Times.Once()
        );
    }
    [Fact]
    public void Get_OnSuccess_ReturnsListOfSubjects()
    {
        // Arrange
        var mockSubjectRepository = new Mock<ISubjectRepository>();

        mockSubjectRepository
            .Setup(resp => resp.GetAllSubjects())
            .Returns(new List<Subject>());

        var sut = new SubjectController(mockSubjectRepository.Object);

        // Act
        var result = sut.GetAll();

        // Assert
        var okResult = result.Should().BeOfType<OkObjectResult>();
        var objectResult = (OkObjectResult)result;
        objectResult.Value.Should().BeOfType<List<Subject>>();
    }
}