//
//  TelegramUser.cs
//
//  Authors:
//       Justin Chase <justin@thebackroom.app>
//       &
//       Municipal Drew <drew@wheatleythecat.com>
//
//  Copyright ©️ 2022 2022 Justin Chase
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

namespace Backroom.Identity.Models;
// using Abstractions;

// [Table(TblUserRole, Schema = SchId), DebuggerDisplay("User Role ({Id} - User ID: {UserId}, Role: {Role})")]
// public class BackroomUserRole : IdentityUserRole<BackroomKey>, IHaveAnId<BackroomKey>, IUserAssociatedEntity//, IHaveTimestamps
// {
//     [Key, DatabaseGenerated(DbGenO.None), Column(ColId, Order = 0, TypeName = TInt)]
//     public virtual BackroomKey Id { get; set; } //= NewId;

//     [Column(nameof(RoleId), Order = 2, TypeName = TInt)]
//     public override BackroomKey RoleId { get => base.RoleId; set => base.RoleId = value; }

//     [Column(ColUserId, Order = 1, TypeName = TInt)]
//     public override BackroomKey UserId { get => base.UserId; set => base.UserId = value; }

//     //[ForeignKey(ColUserId)]
//     //public virtual BackroomUser User { get; set; }

//     //[ForeignKey(nameof(RoleId))]
//     //public virtual BackroomRole Role { get; set; }


//     //         public Timestamp Created { get; set; }
//     //         public Timestamp LastUpdated { get; set; }
//     //         public Timestamp? Deleted { get; set; }
// }
