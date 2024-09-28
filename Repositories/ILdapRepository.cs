using DotNetCrudWebApi.Models;
using LdapForNet;

namespace DotNetCrudWebApi.Repositories {
    public interface ILdapRepository {
        public IList<LdapEntry>? GetWhoAmI(SignInDTO signIn);
    }
}