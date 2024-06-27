namespace swashbuckle_generic_action_missing;

/// <summary>
/// Base profile.
/// </summary>
public class BaseProfile
{
    /// <summary>
    /// Shared base prop among all profiles.
    /// </summary>
    public string BaseProp { get; set; }
}

/// <summary>
/// Some profile.
/// </summary>
public class SomeProfile : BaseProfile
{
    /// <summary>
    /// Some property.
    /// </summary>
    public string SomeProp { get; set; }
}

/// <summary>
/// Other profile.
/// </summary>
public class OtherProfile : BaseProfile
{
    /// <summary>
    /// Other property.
    /// </summary>
    public string OtherProp { get; set; }
}

/// <summary>
/// Different profile.
/// </summary>
public class DifferentProfile : BaseProfile
{
    /// <summary>
    /// Different property.
    /// </summary>
    public string DifferentProp { get; set; }
}