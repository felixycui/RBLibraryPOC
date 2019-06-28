using System;

public class TopCapability : ICapability
{
    bool ICapability.IsSupported(IEdmModel model, ODataPath path)
    {
        throw new NotImplementedException();
    }

    CapabilityType ICapability.GetType()
    {
        throw new NotImplementedException();
    }
}
