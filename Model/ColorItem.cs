using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
namespace WpfAppexampl.Model
{
    
        public class ColorItem
        {
            public Color Color { get; set; }
            public string DisplayName => $"A: {Color.A}, R: {Color.R}, G: {Color.G}, B: {Color.B}";
        }
    }

