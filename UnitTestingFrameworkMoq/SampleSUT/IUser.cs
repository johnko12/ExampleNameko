using System;

namespace SampleSUT
{
    public interface IUser
    {
        int CalculateAge();
        DateTime DateOfBirth { get; set; }
        string Name { get; set; }
    }
}
