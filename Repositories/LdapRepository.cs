using AutoMapper;
using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Models;
using LdapForNet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudWebApi.Repositories
{
    public class LdapRepository : ILdapRepository {
        private LdapConnection cn;

        LdapRepository() {
            cn = new LdapConnection();
            cn.Connect(new Uri("ldap://localhost:1389"));
        }

        public IList<LdapEntry>? GetWhoAmI(SignInDTO signIn)
        {
            cn.Bind(
                LdapForNet.Native.Native.LdapAuthMechanism.SIMPLE,
                string.Format("cn={0},ou=users,dc=example,dc=ru", signIn.Username),
                signIn.Password
            );
            var item = cn.SearchByCn(signIn.Username);
            return item;
        }
    }
}