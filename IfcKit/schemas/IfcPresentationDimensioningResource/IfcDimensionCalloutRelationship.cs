// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPresentationDimensioningResource
{
	public partial class IfcDimensionCalloutRelationship : IfcDraughtingCalloutRelationship
	{
	
		public IfcDimensionCalloutRelationship(IfcLabel? __Name, IfcText? __Description, IfcDraughtingCallout __RelatingDraughtingCallout, IfcDraughtingCallout __RelatedDraughtingCallout)
			: base(__Name, __Description, __RelatingDraughtingCallout, __RelatedDraughtingCallout)
		{
		}
	
	
	}
	
}
