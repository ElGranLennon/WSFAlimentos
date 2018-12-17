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
//ORIGINAL LINE: @Entity @Table(name = "subtipo_producto") @XmlRootElement @NamedQueries({ @NamedQuery(name = "SubtipoProducto.findAll", query = "SELECT s FROM SubtipoProducto s"), @NamedQuery(name = "SubtipoProducto.findBySubtipoP", query = "SELECT s FROM SubtipoProducto s WHERE s.subtipoProductoPK.subtipoP = :subtipoP"), @NamedQuery(name = "SubtipoProducto.findByDescripcionStp", query = "SELECT s FROM SubtipoProducto s WHERE s.descripcionStp = :descripcionStp"), @NamedQuery(name = "SubtipoProducto.findByTipoProductoIdTp", query = "SELECT s FROM SubtipoProducto s WHERE s.subtipoProductoPK.tipoProductoIdTp = :tipoProductoIdTp")}) public class SubtipoProducto implements java.io.Serializable
	[Serializable]
	public class SubtipoProducto
	{

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @EmbeddedId protected SubtipoProductoPK subtipoProductoPK;
		protected internal SubtipoProductoPK subtipoProductoPK;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "descripcion_stp") private String descripcionStp;
		private string descripcionStp;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumn(name = "tipo_producto_id_tp", referencedColumnName = "id_tp", insertable = false, updatable = false) @ManyToOne(optional = false) private TipoProducto tipoProducto;
		private TipoProducto tipoProducto;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "subtipoProducto") private java.util.List<Producto> productoList;
		private IList<Producto> productoList;

		public SubtipoProducto()
		{
		}

		public SubtipoProducto(SubtipoProductoPK subtipoProductoPK)
		{
			this.subtipoProductoPK = subtipoProductoPK;
		}

		public SubtipoProducto(SubtipoProductoPK subtipoProductoPK, string descripcionStp)
		{
			this.subtipoProductoPK = subtipoProductoPK;
			this.descripcionStp = descripcionStp;
		}

		public SubtipoProducto(short subtipoP, short tipoProductoIdTp)
		{
			this.subtipoProductoPK = new SubtipoProductoPK(subtipoP, tipoProductoIdTp);
		}

		public virtual SubtipoProductoPK SubtipoProductoPK
		{
			get
			{
				return subtipoProductoPK;
			}
			set
			{
				this.subtipoProductoPK = value;
			}
		}


		public virtual string DescripcionStp
		{
			get
			{
				return descripcionStp;
			}
			set
			{
				this.descripcionStp = value;
			}
		}


		public virtual TipoProducto TipoProducto
		{
			get
			{
				return tipoProducto;
			}
			set
			{
				this.tipoProducto = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<Producto> getProductoList()
		public virtual IList<Producto> ProductoList
		{
			get
			{
				return productoList;
			}
			set
			{
				this.productoList = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (subtipoProductoPK != null ? subtipoProductoPK.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is SubtipoProducto))
			{
				return false;
			}
			SubtipoProducto other = (SubtipoProducto) @object;
			if ((this.subtipoProductoPK == null && other.subtipoProductoPK != null) || (this.subtipoProductoPK != null && !this.subtipoProductoPK.Equals(other.subtipoProductoPK)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.SubtipoProducto[ subtipoProductoPK=" + subtipoProductoPK + " ]";
		}

	}

}