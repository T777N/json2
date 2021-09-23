
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace asdasdasd.Command
{
    class Process
    {
        public void Start(int number,Models.Properties properties)
        {
            if (number == 1)
            {

                Repo.Xmladapter xmladapter = new Repo.Xmladapter();
                xmladapter.Add(properties);

                
            }
            else if (number ==2)
            {
                Repo.Jsonadapter jsonadapter = new Repo.Jsonadapter();
                jsonadapter.Add(properties);

            }

        }
    }
}
