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
            "Leo",
            "Messi",
            "messi@pjwstk.edu.pl",
            DateTime.Now.AddYears(5),
            1
        );
        
        //Assert
        Assert.False(result);
    }


    [Fact]
    public void AddUser_ReturnsTrueWhenVeryImportantClient()
    {
        
    }
    
    
    // AddUser_ReturnsFalseWhenYoungerThen21YearsOld  =========================
    // AddUser_ReturnsTrueWhenVeryImportantClient
    // AddUser_ReturnsTrueWhenImportantClient
    // AddUser_ReturnsTrueWhenNormalClient
    // AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit
    // AddUser_ThrowsExceptionWhenUserDoesNotExist
    // AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser
    
    
    
    
    
}