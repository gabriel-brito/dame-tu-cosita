using dame_tu_cosita.IO;

namespace dame_tu_cosita.UseCases.User;

public class Create
{
    public UserOutput Execute(UserInput newUser)
    {
        var possibility = new Random().Next(0, 10);

        if (possibility < 5)
        {
            return null;
        }

        var result = new UserOutput()
        {
            Name = newUser.Name,
            Id = 2345678
        };


        return result;
    }
}
