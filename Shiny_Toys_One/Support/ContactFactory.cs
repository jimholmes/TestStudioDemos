using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shiny_Toys_One
{
    static class ContactFactory
    {
        static public int CreateNewContact()
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"d:\temp\sqlite3.exe";
            proc.StartInfo.Arguments = "development.sqlite3 \"delete from contacts where email like '%foo.com';insert into contacts (first_name, last_name, email, linkedin_profile, lead_type) values ('New', 'User', 'new.user@foo.com', 'http://linkedin.com/newuser','NEUTRAL');\"";
            proc.StartInfo.WorkingDirectory = @"D:\projects\Telerik-Demo\db";
            proc.Start();
            proc.WaitForExit();

            //I would more likely return the ID value from the new user
            return 0;
        }
    }
}
