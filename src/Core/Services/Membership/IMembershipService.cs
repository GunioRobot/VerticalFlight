using System;
using System.Web.Security;

namespace VerticalFlight.Core.Services.Membership
{
    public interface IMembershipService
    {
        int MinPasswordLength { get; }
        bool ValidateUser(string userName, string password);
        MembershipCreateStatus CreateUser(string userName, string password, string email);
        bool ChangePassword(string userName, string oldPassword, string newPassword);
        Guid GetUserIdFor(string userName);
    }
}