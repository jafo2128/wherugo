//  wherugo - WherUGo for Magellan eXplorist x10
//  Copyright (C) 2011 Peter Siegmund <developer@mars3142.org>
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace org.mars3142.wherugo.Controls
{
   public class CListBoxItem
   {
      private String itemKey;
      public String ItemKey
      {
         get
         {
            return itemKey;
         }
         set
         {
            itemKey = value;
         }
      }

      private String itemValue;
      public String ItemValue
      {
         get
         {
            return itemValue;
         }
         set
         {
            itemValue = value;
         }
      }
   }
}
