namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        //Arrange
        var userService = new UserService();
        //Act
        var result = userService.AddUser(
            null,
            "Kowalski",
            "kowalski@gmail.com",
            DateTime.Parse("2000-01-01"),
            1);
        //Assert
        
        //Assert.Equal(false,result);
        Assert.False(result);
    }
    
    
    
    
    
    [Fact]
    public void AddUser_ThrowsExceptionWhenClientDoesNotExist()
    {
        //Arrange
        
        var userService = new UserService();
        
        //Act
        
        
        Action action = () => { userService.AddUser(
                    "Jan",
                    "kowalski",
                    "kowalski@gmail.com",
                    DateTime.Parse("2000-01-01"),
                    100
                    );};
        
        
        //Assert

        
        
        //Assert.Equal(false,result);
        Assert.Throws<ArgumentException>(action);
    }
    
    
    
    
    // AddUser_ReturnsFalseWhenMissingAtSignAndDotInEmail
    
    [Fact]
    public void AddUser_ReturnsFalseWhenMissingAtSignAndDotInEmail()
    {
        //Arrange
        
        var userService = new UserService();
        
        //Act
        
        
        var result  = userService.AddUser(
            "Jan",
            "Kowalski",
            "kowalskigmail.com",
            DateTime.Parse("2000-01-01"),
            1
        );
        
        
        //Assert
        
        //Assert.Equal(false,result);
        Assert.False(result);
    }

    [Fact]
    public void AddUser_ReturnsFalseWhenYoungerThen21YearsOld()
    {
        //Arange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "Jan",
            "Kowalski",
            "kowalski@wp.pl",
            DateTime.Parse("2010-01-01"),
            1
        );
        
        
        
        //Assert
        Assert.False(result);
    }


    [Fact]
    public void AddUser_ReturnsTrueWhenVeryImportantClient()
    {

        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "Jan",
            "Malewski",
            "malewski@gmail.pl",
            DateTime.Parse("2000-01-01"),
            2
        );
        
        
        //Assert
        Assert.True(result);

    }
    
    
    [Fact]
    public void AddUser_ReturnsTrueWhenImportantClient()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "Jan",
            "Smith",
            "smith@gmail.pl",
            DateTime.Parse("2000-01-01"),
            3
        );

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void AddUser_ReturnsTrueWhenNormalClient()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "Leo",
            "Kwiatkowski",
            "andrzejewicz@wp.pl",
            DateTime.Parse("2000-01-01"),
            5
        );

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "Jan",
            "Kowalski",
            "kwiatkowski@wp.pl",
            DateTime.Parse("2000-01-01"),
            1
        );

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser()
    {
        //Arrange
        var userService = new UserService();

        //Act 


        Action result = () =>
        {
            userService.AddUser(
                "Jan",
                "Andrzejewicz",
                "andrzejewicz@wp.pl",
                DateTime.Parse("2000-01-01"),
                6
            );
        };

    //Assert
        Assert.Throws<ArgumentException>(result);

    }
    
    
    
    
    // AddUser_ReturnsFalseWhenYoungerThen21YearsOld  =========================
    // AddUser_ReturnsTrueWhenVeryImportantClient ===================
    // AddUser_ReturnsTrueWhenImportantClient ============
    // AddUser_ReturnsTrueWhenNormalClient ==============
    // AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit ==============
    // AddUser_ThrowsExceptionWhenUserDoesNotExist ===================
    // AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser ==============
    
    
    
    
    
}