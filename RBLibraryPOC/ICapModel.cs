using System;

public interface ICapModel
{
    private IEnumerable<ICapability> capabilities; 

    // Have parameter of capabilities?
    public ICapModel(IEnumerable<ICapability> capabilities)
	{
        this.capabilities = capabilities;  
	}

    IEnumerable<Function> GetFunctions();

    IEnumerable<Action> GetActions();

    IEnumerable<StructuralProperty> GetStructuralProperties();

    IEnumerable<NavigationProperty> GetNavigationProperties();

    void RegisterCapability(ICapability capability);


}
