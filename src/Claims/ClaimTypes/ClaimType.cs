namespace JustinWritesCode.Identity;
using System;
using JustinWritesCode.Tuples;

public class ClaimType : UriDescriptionTuple
{
    public virtual ClaimValueType ValueType { get; }

    public ClaimType(@uri? uri, string? description = null, uri? claimValueType = null) : base(uri, description)
    {
        ValueType = claimValueType != null ? new ClaimValueType(claimValueType, null as string/*, null as IValidator<C>*/) : new ClaimValueType(JwcCvt.String);
    }
    public ClaimType(string? uri, string? description = null, string? claimValueType = null) : this(uri.ToUri(), description, claimValueType?.ToUri()!) { }

    public override string ToString() => Uri.ToString();

    public static implicit operator string(ClaimType claimType) => claimType.Uri.ToString();
    public static implicit operator uri?(ClaimType claimType) => claimType.Uri;
    //public static implicit operator ClaimType((Uri, string) tuple) => new ClaimType(tuple.Item1, tuple.Item2, null as Uri);
#if NETSTANDARD2_0_OR_GREATER
    public static implicit operator ClaimType((string, string) tuple) => new(tuple.Item1, tuple.Item2, null as string);
    public static implicit operator ClaimType((uri, string) tuple) => new (tuple.Item1, tuple.Item2, null as uri);
    public static implicit operator ClaimType((string, string, string) tuple) => new (tuple.Item1, tuple.Item2, tuple.Item3);
    public static implicit operator ClaimType((uri, string, ClaimValueType) tuple) => new (tuple.Item1, tuple.Item2, tuple.Item3);
#endif
}
