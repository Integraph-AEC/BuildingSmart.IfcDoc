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


namespace BuildingSmart.IFC.IfcMeasureResource
{
	public partial class IfcContextDependentUnit : IfcNamedUnit
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The word, or group of words, by which the context dependent unit is referred to.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
	
		public IfcContextDependentUnit(IfcDimensionalExponents __Dimensions, IfcUnitEnum __UnitType, IfcLabel __Name)
			: base(__Dimensions, __UnitType)
		{
			this.Name = __Name;
		}
	
	
	}
	
}
