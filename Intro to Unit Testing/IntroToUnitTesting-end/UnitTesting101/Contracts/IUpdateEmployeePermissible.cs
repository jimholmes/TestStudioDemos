using UnitTesting101.Domain;

namespace UnitTesting101.Contracts
{
    public interface IUpdateEmployeePermissible
    {
        bool CanUpdateEmployeeRate(int targetEmployeeId);
        //        bool CanUpdateTargetEmployeeDepartment(Employee currentUser, Employee targetUser);
        //        bool CanUpdateTargetEmployeeAddress(Employee currentUser, Employee targetUser);
    }
}
