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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationDefinitionResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcPresentationDimensioningResource
{
	public partial class IfcTerminatorSymbol : IfcAnnotationSymbolOccurrence
	{
		[DataMember(Order = 0)] 
		[Description("The curve being annotated by the terminator symbol.")]
		[Required()]
		public IfcAnnotationCurveOccurrence AnnotatedCurve { get; set; }
	
	
		public IfcTerminatorSymbol(IfcRepresentationItem __Item, IfcPresentationStyleAssignment[] __Styles, IfcLabel? __Name, IfcAnnotationCurveOccurrence __AnnotatedCurve)
			: base(__Item, __Styles, __Name)
		{
			this.AnnotatedCurve = __AnnotatedCurve;
		}
	
	
	}
	
}
