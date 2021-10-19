using System;

namespace HazaelP1WebApi.Domain
{
    public record Person(int Id, string FirstName, string LastName, string Email, string Gender, string Job, int Age);
}