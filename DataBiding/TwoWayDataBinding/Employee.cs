using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwoWayDataBinding
{


    public class Employee : INotifyPropertyChanged
        {
            private string name;
            private string title;

            public string Name
            {
                get { return name; }

                set
                {
                    name = value;
                    onPropertyChanged();
                }
            }


            public string Title
            {
                get { return title; }

                set
                {
                    title = value;
                    onPropertyChanged();

                }
            }

            public static Employee GetEmployee()
            {
                var emp = new Employee();

                return emp;
            }




            public event PropertyChangedEventHandler PropertyChanged;

            private void onPropertyChanged(
            [CallerMemberName] string caller = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs(caller));
                }
            }


        }
    }

