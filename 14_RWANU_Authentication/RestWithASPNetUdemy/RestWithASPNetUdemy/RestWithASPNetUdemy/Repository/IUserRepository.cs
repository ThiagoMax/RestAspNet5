using RWANU.Data.VO;
using RWANU.Model;

namespace RWANU.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
