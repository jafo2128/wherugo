//  wherugo - WherUGo for Magellan eXplorist x10
//  Copyright (C) 2011-2012 Peter Siegmund <developer@mars3142.org>
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using org.mars3142.wherugo.cartridges;
using org.mars3142.wherugo.shared;
using System.Resources;

namespace org.mars3142.wherugo.decoder.Windows
{
   public partial class ObjectWindow : Form
   {
      File _gwc = null;

      public ObjectWindow(File gwc)
      {
         InitializeComponent();
         MessageBox.Show(Locale.GetString("label_east"));
         _gwc = gwc;
         InitializeData();
      }

      private void InitializeData()
      {
         lbObject.Items.Clear();
         foreach (KeyValuePair<short, Objects> pair in _gwc.cartridge.Obj())
         {
            lbObject.Items.Add(String.Format("{0} ({1} - {2:0,000} Bytes)", pair.Value.ObjectId, pair.Value.ObjectTypeString, pair.Value.Data.Length));
         }
      }

      private void lbObject_SelectedIndexChanged(object sender, EventArgs e)
      {
         short Id;
         Objects obj;

         Id = Convert.ToInt16(lbObject.SelectedItem.ToString().Split(' ')[0]);
         obj = _gwc.cartridge.GetObject(Id);
         if (obj.ObjectType >= 1 && obj.ObjectType <= 4)
         {
            ImageConverter ic = new ImageConverter();
            Image objImage = (Image)ic.ConvertFrom(obj.Data);
            Bitmap objBitmap = new Bitmap(objImage);
            pbImage.Image = objBitmap;
         }
         else
         {
            pbImage.Image = null;
         }
      }
   }
}