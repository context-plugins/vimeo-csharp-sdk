using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The state of the SSL certificate that is associated with the showcase's domain.
/// <para>
/// Option descriptions:
///  * <c>0</c> - The new certificate has yet to be processed.
///  * <c>1</c> - The new certificate is being processed in the queue.
///  * <c>2</c> - The certificate is being processed for renewal in the queue.
///  * <c>3</c> - The new certificate has failed to be issued in the queue.
///  * <c>4</c> - The certificate has failed to be renewed in the queue.
///  * <c>5</c> - The certificate has been successfully issued.
///  * <c>6</c> - The certificate has been successfully renewed.
///  * <c>7</c> - The certificate has failed in the polling flow.
///  * <c>8</c> - The certificate has failed to be renewed in the polling flow.
///  * <c>null</c> - There is no associated HTTPS domain with this showcase.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DomainCertificateState>))]
public sealed record DomainCertificateState : StringEnum<DomainCertificateState>
{
    private DomainCertificateState(string value) : base(value)
    {
    }

    public static readonly DomainCertificateState _0 = new("0");

    public static readonly DomainCertificateState _1 = new("1");

    public static readonly DomainCertificateState _2 = new("2");

    public static readonly DomainCertificateState _3 = new("3");

    public static readonly DomainCertificateState _4 = new("4");

    public static readonly DomainCertificateState _5 = new("5");

    public static readonly DomainCertificateState _6 = new("6");

    public static readonly DomainCertificateState _7 = new("7");

    public static readonly DomainCertificateState _8 = new("8");

    public static readonly DomainCertificateState Null = new("null");

    public static DomainCertificateState FromValue(string value) => FromValueCore(value);
}
