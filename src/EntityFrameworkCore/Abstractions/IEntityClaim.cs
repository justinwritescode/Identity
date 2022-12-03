//
//  IEntityClaim.cs
//
//  Authors:
//       Justin Chase <justin@thebackroom.app>
//       &
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 Justin Chase
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
namespace Backroom.Identity.Models.Abstractions
{
    public interface IEntityClaim : IHaveAnId<BackroomKey>
    {
        BackroomKey EntityId { get; set; }
        Uri ValueType { get; set; }
        Uri Type { get; set; }
        string Value { get; set; }
        Uri Issuer { get; set; }
        Uri OriginalIssuer { get; set; }

        [/*Column(nameof(Properties),*/NotMapped/*, Order = 9, TypeName = TypNvarchar), StringLength(4096)*/]
        IStringDictionary Properties { get; set; }
        //protected IStringDictionary _properties { get; set; }
        //private void OnPropertyAdded(IEnumerable<StrKvp> addedPairs)
        //{
        //    PropertiesJson = Serialize(Properties);
        //}
        //private void OnPropertyRemoved(IEnumerable<StrKvp> removedPairs)
        //{
        //    PropertiesJson = Serialize(Properties);
        //}
    }
}

