using System;

public class SelectCapability : ICapability
{
    bool ICapability.IsSupported(IEdmModel model, ODataPath path)
    {
        throw new NotImplementedException();
    }

    CapabilityType ICapability.GetType()
    {
        return CapabilityType.Select;
    }
}
