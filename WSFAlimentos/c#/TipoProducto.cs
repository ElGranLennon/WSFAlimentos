using System;
using System.Collections.Generic;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace dto.clases
{

	/// 
	/// <summary>
	/// @author Patricio
	/// </summary>
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Entity @Table(name = "tipo_producto") @XmlRootElement @NamedQueries({ @NamedQuery(name = "TipoProducto.findAll", query = "SELECT t FROM TipoProducto t"), @NamedQuery(name = "TipoProducto.findByIdTp", query = "SELECT t FROM TipoProducto t WHERE t.idTp = :idTp"), @NamedQuery(name = "TipoProducto.findByDescripcionTp", query = "SELECT t FROM TipoProducto t WHERE t.descripcionTp = :descripcionTp")}) public class TipoProducto implements java.io.Serializable
	[Serializable]
	public class TipoProducto
	{

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @GeneratedValue(strategy = javax.persistence.GenerationType.IDENTITY) @Basic(optional = false) @Column(name = "id_tp") private System.Nullable<short> idTp;
		private short? idTp;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "descripcion_tp") private String descripcionTp;
		private string descripcionTp;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "tipoProducto") private java.util.List<SubtipoProducto> subtipoProductoList;
		private IList<SubtipoProducto> subtipoProductoList;

		public TipoProducto()
		{
		}

		public TipoProducto(short? idTp)
		{
			this.idTp = idTp;
		}

		public TipoProducto(short? idTp, string descripcionTp)
		{
			this.idTp = idTp;
			this.descripcionTp = descripcionTp;
		}

		public virtual short? IdTp
		{
			get
			{
				return idTp;
			}
			set
			{
				this.idTp = value;
			}
		}


		public virtual string DescripcionTp
		{
			get
			{
				return descripcionTp;
			}
			set
			{
				this.descripcionTp = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<SubtipoProducto> getSubtipoProductoList()
		public virtual IList<SubtipoProducto> SubtipoProductoList
		{
			get
			{
				return subtipoProductoList;
			}
			set
			{
				this.subtipoProductoList = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idTp != null ? idTp.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is TipoProducto))
			{
				return false;
			}
			TipoProducto other = (TipoProducto) @object;
			if ((this.idTp == null && other.idTp != null) || (this.idTp != null && !this.idTp.Equals(other.idTp)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.TipoProducto[ idTp=" + idTp + " ]";
		}

	}

}