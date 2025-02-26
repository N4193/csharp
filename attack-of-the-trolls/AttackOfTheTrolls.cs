using System;
using System.Reflection;

[Flags]
enum AccountType : byte
{
    Guest = 0b_0010_0001,//1
    User = 0b_0100_0011,//1+2=3
    Moderator = 0b_1000_0111//1+2+4=7
}

[Flags]
enum Permission : byte
{
    None = 0b_0000_0000,
    Read = 0b_0000_0001,
    Write = 0b_0000_0010,
    Delete = 0b_0000_0100,
    All = 0b_0000_0111
}
/*
     0 = None           => 0
     1 = Read           => 1
     2 = Write          => 2
     3 = Read, Write    => 2+1=3
     4 = Delete         => 4
     5 = Read, Delete   => 4+1=5
     6 = Write, Delete  => 4+2=6
     7 = All            => 4+2+1=7
*/
static class Permissions
{
    public static Permission Default(AccountType accountType) => accountType switch
        {
            AccountType.Guest => (Permission)1,
            AccountType.User => (Permission)3,
            AccountType.Moderator => (Permission)7,
            _ => (Permission)0
        };
    public static Permission Grant(Permission current, Permission grant) => current | grant;
    public static Permission Revoke(Permission current, Permission revoke) => current & ~revoke;
    public static bool Check(Permission current, Permission check) => (current & check)==check ? true : false; 
}
