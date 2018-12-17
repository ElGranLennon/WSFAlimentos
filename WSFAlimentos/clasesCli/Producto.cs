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
//ORIGINAL LINE: @Entity @Table(name = "producto") @XmlRootElement @NamedQueries({ @NamedQuery(name = "Producto.findAll", query = "SELECT p FROM Producto p"), @NamedQuery(name = "Producto.findByIdProducto", query = "SELECT p FROM Producto p WHERE p.idProducto = :idProducto"), @NamedQuery(name = "Producto.findByNombreProducto", query = "SELECT p FROM Producto p WHERE p.nombreProducto = :nombreProducto"), @NamedQuery(name = "Producto.findByPrecioProducto", query = "SELECT p FROM Producto p WHERE p.precioProducto = :precioProducto"), @NamedQuery(name = "Producto.findByAnioF", query = "SELECT p FROM Producto p WHERE p.anioF = :anioF"), @NamedQuery(name = "Producto.findByAnioV", query = "SELECT p FROM Producto p WHERE p.anioV = :anioV"), @NamedQuery(name = "Producto.findByDescripcionProducto", query = "SELECT p FROM Producto p WHERE p.descripcionProducto = :descripcionProducto"), @NamedQuery(name = "Producto.findByTarificacion", query = "SELECT p FROM Producto p WHERE p.tarificacion = :tarificacion")}) public class Producto implements java.io.Serializable
	[Serializable]
	public class Producto
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "productoIdProducto") private java.util.List<Detalle> detalleList;
		private IList<Detalle> detalleList;

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @GeneratedValue(strategy = javax.persistence.GenerationType.IDENTITY) @Basic(optional = false) @Column(name = "id_producto") private System.Nullable<short> idProducto;
		private short? idProducto;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "nombre_producto") private String nombreProducto;
		private string nombreProducto;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "precio_producto") private int precioProducto;
		private int precioProducto;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Column(name = "anio_f") @Temporal(javax.persistence.TemporalType.TIMESTAMP) private java.util.Date anioF;
		private DateTime anioF;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Column(name = "anio_v") @Temporal(javax.persistence.TemporalType.TIMESTAMP) private java.util.Date anioV;
		private DateTime anioV;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Size(max = 45) @Column(name = "descripcion_producto") private String descripcionProducto;
		private string descripcionProducto;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Column(name = "tarificacion") private System.Nullable<int> tarificacion;
		private int? tarificacion;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumns({ @JoinColumn(name = "subtipo_producto_subtipo_p", referencedColumnName = "subtipo_p"), @JoinColumn(name = "subtipo_producto_tipo_producto_id_tp", referencedColumnName = "tipo_producto_id_tp")}) @ManyToOne(optional = false) private SubtipoProducto subtipoProducto;
		private SubtipoProducto subtipoProducto;

		public Producto()
		{
		}

		public Producto(short? idProducto)
		{
			this.idProducto = idProducto;
		}

		public Producto(short? idProducto, string nombreProducto, int precioProducto)
		{
			this.idProducto = idProducto;
			this.nombreProducto = nombreProducto;
			this.precioProducto = precioProducto;
		}

		public virtual short? IdProducto
		{
			get
			{
				return idProducto;
			}
			set
			{
				this.idProducto = value;
			}
		}


		public virtual string NombreProducto
		{
			get
			{
				return nombreProducto;
			}
			set
			{
				this.nombreProducto = value;
			}
		}


		public virtual int PrecioProducto
		{
			get
			{
				return precioProducto;
			}
			set
			{
				this.precioProducto = value;
			}
		}


		public virtual DateTime AnioF
		{
			get
			{
				return anioF;
			}
			set
			{
				this.anioF = value;
			}
		}


		public virtual DateTime AnioV
		{
			get
			{
				return anioV;
			}
			set
			{
				this.anioV = value;
			}
		}


		public virtual string DescripcionProducto
		{
			get
			{
				return descripcionProducto;
			}
			set
			{
				this.descripcionProducto = value;
			}
		}


		public virtual int? Tarificacion
		{
			get
			{
				return tarificacion;
			}
			set
			{
				this.tarificacion = value;
			}
		}


		public virtual SubtipoProducto SubtipoProducto
		{
			get
			{
				return subtipoProducto;
			}
			set
			{
				this.subtipoProducto = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idProducto != null ? idProducto.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is Producto))
			{
				return false;
			}
			Producto other = (Producto) @object;
			if ((this.idProducto == null && other.idProducto != null) || (this.idProducto != null && !this.idProducto.Equals(other.idProducto)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.Producto[ idProducto=" + idProducto + " ]";
		}

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<Detalle> getDetalleList()
		public virtual IList<Detalle> DetalleList
		{
			get
			{
				return detalleList;
			}
			set
			{
				this.detalleList = value;
			}
		}


	}

}