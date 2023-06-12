﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step04
{
    class Profile
    {
        private string name;
        private int height;
        public string Name { get => name; set => name = value; }
        public int Height { get => height; set => height = value; }
    }
    internal class LINQ_2
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            var profiles = from profile in arrProfile
                           orderby profile.Height descending
                           where profile.Height >= 175
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };
            foreach ( var profile in profiles )
            {
                Console.WriteLine($"{profile.Name} - {profile.InchHeight}");
            }
        }
    }
}
