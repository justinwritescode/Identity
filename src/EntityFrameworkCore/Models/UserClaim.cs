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

// [Table(TblClaim, Schema = SchId), DebuggerDisplay("User Claim ({Id} - User ID: {UserId}, {Type}: {Value})")]
// public class BackroomUserClaim : IdentityUserClaim<BackroomKey>, IHaveAnId<BackroomKey>, IEntityClaim, IUserAssociatedEntity//, IHaveTimestamps
// {
//     public BackroomUserClaim() { }
//     public BackroomUserClaim(BackroomKey userId, Uri claimType, string claimValue, Uri? claimValueType = null, Uri? issuer = null, Uri? originalIssuer = null, IDictionary<string, string>? properties = null)
//     {
//         Properties = properties ?? new StringDictionary { { nameof(Id), NewId().ToString() }, { nameof(UserId), UserId.ToString() } };
//         UserId = userId;
//         Type = claimType;
//         Value = claimValue;
//         ValueType = claimValueType ?? StringClaimValueType;
//         Issuer = issuer ?? BackroomBaseUri;
//         OriginalIssuer = originalIssuer ?? issuer ?? BackroomBaseUri;
//     }

//     [Key, DatabaseGenerated(DbGenO.None), Hashid, Column(ColId, Order = 0, TypeName = TInt), Required]
//     public override BackroomKey Id
//     {
//         get => base.Id = ToInt32(base.Id != default ? base.Id : Properties.ContainsKey(ColId) ? BackroomKey.Parse(Properties[ColId]) : default);
//         set
//         {
//             base.Id = ToInt32(BackroomKey.Parse(Properties[ColId] = value.ToString()));
//         }
//     }

//     [Column(ColUserId, Order = 1, TypeName = TInt), Hashid, Required(AllowEmptyStrings = false, ErrorMessage = "User ID must be specified.")]
//     public override BackroomKey UserId
//     {
//         get => UserId = base.UserId != default ? base.UserId : Properties.ContainsKey(ColUserId) ? BackroomKey.Parse(Properties[ColUserId]) : default;
//         set => base.UserId = BackroomKey.Parse(Properties[ColUserId] = value.ToString());
//     }

//     [ForeignKey(ColUserId)]
//     public virtual BackroomUser? User { get; set; }

//     [Column(nameof(Type), Order = 2, TypeName = TNVarChar), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri Type { get => ClaimType.ToUri()!; set => ClaimType = value.ToString(); }

//     [Column(nameof(ValueType), Order = 3, TypeName = TNVarChar), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri ValueType { get => _valueType!.ToUri()!; set => _valueType = value?.ToString(); }
//     private string? _valueType = default;

//     [Column(nameof(Value), Order = 4, TypeName = TNVarChar), Url, StringLength(1024), Required(AllowEmptyStrings = false, ErrorMessage = "A value must be specified.")]
//     public virtual string? Value { get => ClaimValue; set => ClaimValue = value; }

//     [Column(nameof(Issuer), Order = 5, TypeName = TNVarChar), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri Issuer { get => _issuer!.ToUri()!; set => _issuer = value?.ToString(); }
//     private string? _issuer = default;

//     [Column(nameof(OriginalIssuer), Order = 6, TypeName = TNVarChar), Url, StringLength(UriMaxLength), Required]
//     public virtual Uri OriginalIssuer { get => _originalIssuer!.ToUri()!; set => _originalIssuer = value?.ToString(); }
//     private string? _originalIssuer = default;

//     [Column(nameof(Properties), Order = 7, TypeName = TNVarChar), StringLength(2048)]
//     public virtual IStringDictionary Properties { get; set; } = new StringDictionary();
//     //{
//     //    get => _properties = new ActionedObservableDictionary<string, string>(_properties, OnPropertyAdded, OnPropertyRemoved);
//     //    set
//     //    {
//     //        _properties = new ActionedObservableDictionary<string,string>(value, OnPropertyAdded, OnPropertyRemoved);
//     //        PropertiesJson = Serialize(value);
//     //    }
//     //}
//     //private IStringDictionary _properties = new StringDictionary();
//     //private void OnPropertyAdded(IEnumerable<StrKvp> addedPairs)
//     //{
//     //    PropertiesJson = Serialize(Properties);
//     //}
//     //private void OnPropertyRemoved(IEnumerable<StrKvp> removedPairs)
//     //{
//     //    PropertiesJson = Serialize(Properties);
//     //}

//     //[Column(nameof(Properties), Order = 7, TypeName = TypNvarchar), StringLength(2048)]
//     //public virtual string PropertiesJson { get; set; } = $@"{{ {{ ""{nameof(UserId)}"": ""{default(BackroomKey)}"" }}, {{ ""{nameof(Id)}"": ""{default(BackroomKey)}"" }} }}";

//     BackroomKey IEntityClaim.EntityId { get => UserId; set => UserId = value; }

//     public override void InitializeFromClaim(C claim)
//     {
//         base.InitializeFromClaim(claim);
//         Type = claim.Type.ToUri()!;
//         Value = claim.Value;
//         Issuer = claim.Issuer.ToUri()!;
//         OriginalIssuer = claim.OriginalIssuer.ToUri()!;
//         Properties = claim.Properties;
//         ValueType = claim.ValueType.ToUri()!;
//         UserId = claim.Properties.ContainsKey(nameof(UserId)) ? BackroomKey.Parse(claim.Properties[nameof(UserId)]) : default;
//         Id = claim.Properties.ContainsKey(nameof(Id)) ? BackroomKey.Parse(claim.Properties[nameof(Id)]) : NewId();
//     }

//     public override C ToClaim()
//     {
//         var claim = new C(Type.ToString(),
//            Value,
//            ValueType?.ToString(),
//            Issuer.ToString(),
//            OriginalIssuer.ToString());
//         claim.Properties[nameof(UserId)] = UserId.ToString();
//         claim.Properties[nameof(Id)] = Id.ToString();
//         return claim;
//     }

//     public static BackroomUserClaim FromClaim(BackroomKey userId, C c)
//     {
//         var backroomUserClaim = new BackroomUserClaim();
//         backroomUserClaim.InitializeFromClaim(c);
//         backroomUserClaim.UserId = userId;
//         return backroomUserClaim;
//     }

//     //public static implicit operator BackroomUserClaim((BackroomKey, Uri, string, Uri, Uri, Uri) tuple)
//     //    => (BackroomUserClaim)(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, new Dictionary<string, string>());

//     public static implicit operator C(BackroomUserClaim backroomClaim) => backroomClaim.ToClaim();

//     public static implicit operator BackroomUserClaim(C claim)
//     {
//         var backroomClaim = new BackroomUserClaim();
//         backroomClaim.InitializeFromClaim(claim);
//         return backroomClaim;
//     }


//     [JsonIgnore, NotMapped]
//     public override string? ClaimValue { get => base.ClaimValue; set => base.ClaimValue = value; }

//     [JsonIgnore, NotMapped]
//     public override string? ClaimType { get => base.ClaimType; set => base.ClaimType = value; }

//     //         public Timestamp Created { get; set; }
//     //         public Timestamp LastUpdated { get; set; }
//     //         public Timestamp? Deleted { get; set; }
// }

// //public class BackroomPrimitiveTypeClaim<TPrimitive> : BackroomUserClaim
// //    where TPrimitive : IParseable<TPrimitive>
// //{
// //    public new TPrimitive? Value { get => base.Value == default ? default : TPrimitive.Parse(base.Value, null); set => base.Value = value?.ToString(); }
// //}

// //public class BackroomBooleanUserClaim : BackroomUserClaim
// //{
// //    public new bool? Value { get => base.Value == default ? default : bool.Parse(base.Value); set => base.Value = value?.ToString(); }
// //}
// //public class BackroomLongUserClaim : BackroomPrimitiveTypeClaim<long> { }
// //public class BackroomULongUserClaim : BackroomPrimitiveTypeClaim<ulong> { }
// //public class BackroomIntUserClaim : BackroomPrimitiveTypeClaim<int> { }
// //public class BackroomUIntUserClaim : BackroomPrimitiveTypeClaim<uint> { }
// //public class BackroomDateOnlyUserClaim : BackroomPrimitiveTypeClaim<DateOnly> { }
// //public class BackroomTimeOnlyUserClaim : BackroomPrimitiveTypeClaim<TimeOnly> { }
// //public class BackroomDateTimeUserClaim : BackroomPrimitiveTypeClaim<DateTime> { }
// //public class BackroomHalfUserClaim : BackroomPrimitiveTypeClaim<Half> { }
// //public class BackroomFloatUserClaim : BackroomPrimitiveTypeClaim<float> { }
// //public class BackroomDoubleUserClaim : BackroomPrimitiveTypeClaim<double> { }
// //public class BackroomDecimalUserClaim : BackroomPrimitiveTypeClaim<decimal> { }
// //public class BackroomEmailAddressUserClaim : BackroomUserClaim { public new System.Net.Mail.MailAddress? Value { get => base.Value == default ? default : new(base.Value); set => base.Value = value?.ToString(); } }
// //public class BackroomUriUserClaim : BackroomUserClaim { public new Uri? Value { get => base.Value == default ? default : new(base.Value); set => base.Value = value?.ToString(); } }
