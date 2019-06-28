using System;
using System.Configuration;

public interface IRequestEngine
{
 
	void LoadMetaData(IEdmModel model);

    void LoadMetaData(xmlDocument xmlFile);

    ICapModel GetCapabilities(string resourcePath, ICapModelRequestOptions options);



}
