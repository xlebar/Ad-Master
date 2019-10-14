using System;
namespace CGTK
{
    public partial class Categoria : Gtk.ActionGroup
    {
        public Categoria() :
                base("CGTK.Categoria")
        {
            this.Build();
        }
    }
}
