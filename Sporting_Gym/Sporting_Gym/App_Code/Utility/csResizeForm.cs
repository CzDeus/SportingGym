using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting_Gym.App_Code.Utility
{
    class csResizeForm
    {
        Single f_HeightRatio = new Single();
        Single f_WidthRatio = new Single();

        public void ResizeForm(Form ObjForm, int DesignerWidth, int DesignerHeight)
        {
            int i_StandarHeight = DesignerHeight;
            int i_StandarWidth = DesignerWidth;

            int i_PresentHeight = Screen.PrimaryScreen.Bounds.Height;
            int i_PresentWidth = Screen.PrimaryScreen.Bounds.Width;

            f_HeightRatio = Convert.ToSingle(i_PresentHeight) / Convert.ToSingle(i_StandarHeight);
            f_WidthRatio = Convert.ToSingle(i_PresentWidth) / Convert.ToSingle(i_StandarWidth);

            ObjForm.AutoScaleMode = AutoScaleMode.None;
            ObjForm.Scale(new SizeF(f_WidthRatio, f_HeightRatio));

            foreach (Control c in ObjForm.Controls)
            {
                if (c.HasChildren)
                    ResizeControlStore(c);
                else
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size * f_HeightRatio, c.Font.Style, c.Font.Unit, Convert.ToByte(0));
            }

            ObjForm.Font = new Font(ObjForm.Font.FontFamily, ObjForm.Font.Size * f_HeightRatio, ObjForm.Font.Style, ObjForm.Font.Unit, Convert.ToByte(0));
        }

        public void ResizeControlStore(Control objControl)
        {
            if (objControl.HasChildren)
            {
                foreach (Control c in objControl.Controls)
                {
                    if (c.HasChildren)
                        ResizeControlStore(c);
                    else
                        c.Font = new Font(c.Font.FontFamily, c.Font.Size * f_HeightRatio, c.Font.Style, c.Font.Unit, Convert.ToByte(0));
                }

                objControl.Font = new Font(objControl.Font.FontFamily, objControl.Font.Size * f_HeightRatio, objControl.Font.Style, objControl.Font.Unit, Convert.ToByte(0));
            }
            else
                objControl.Font = new Font(objControl.Font.FontFamily, objControl.Font.Size * f_HeightRatio, objControl.Font.Style, objControl.Font.Unit, Convert.ToByte(0));
        }
    }
}
