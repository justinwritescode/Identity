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
namespace Backroom.Identity.Models.Abstractions;

public interface IBackroomUser : Backroom.Data.Abstractions.IHaveAnId<BackroomKey>
{
    int AccessFailedCount { get; set; }
    bool IsLockoutEnabled { get; set; }
    bool IsEmailConfirmed { get; set; }
    bool IsPhoneNumberConfirmed { get; set; }
    bool IsTwoFactorEnabled { get; set; }
    bool IsLockedOut { get; }
    string Email { get; set; }
    string UserName { get; set; }
    string ConcurrencyStamp { get; set; }
    string PasswordHash { get; set; }
    string SecurityStamp { get; set; }
    string NormalizedEmail { get; set; }
    string NormalizedUserName { get; set; }
}
