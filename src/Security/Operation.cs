/*
 * Operation.cs
 *
 *   Created: 2023-01-03-12:33:03
 *   Modified: 2023-01-03-12:33:04
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Security;

[GenerateEnumerationRecordStruct(nameof(Operations), "JustinWritesCode.Security")]
public enum OperationsEnum
{
    Create,
    Read,
    Update,
    Delete
}
