using System;

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
//ORIGINAL LINE: @Entity @Table(name = "detalle") @XmlRootElement @NamedQueries({ @NamedQuery(name = "Detalle.findAll", query = "SELECT d FROM Detalle d"), @NamedQuery(name = "Detalle.findByIdDetalle", query = "SELECT d FROM Detalle d WHERE d.idDetalle = :idDetalle")}) public class Detalle implements java.io.Serializable
	[Serializable]
	public class Detalle
	{

		private const long serialVersionUID = 1L;
		// @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @Basic(optional = false) @NotNull @Column(name = "id_detalle") private System.Nullable<float> idDetalle;
		private float? idDetalle;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumn(name = "boleta_id_boleta", referencedColumnName = "id_boleta") @ManyToOne(optional = false) private Boleta boletaIdBoleta;
		private Boleta boletaIdBoleta;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumn(name = "producto_id_producto", referencedColumnName = "id_producto") @ManyToOne(optional = false) private Producto productoIdProducto;
		private Producto productoIdProducto;

		public Detalle()
		{
		}

		public Detalle(float? idDetalle)
		{
			this.idDetalle = idDetalle;
		}

		public virtual float? IdDetalle
		{
			get
			{
				return idDetalle;
			}
			set
			{
				this.idDetalle = value;
			}
		}


		public virtual Boleta BoletaIdBoleta
		{
			get
			{
				return boletaIdBoleta;
			}
			set
			{
				this.boletaIdBoleta = value;
			}
		}


		public virtual Producto ProductoIdProducto
		{
			get
			{
				return productoIdProducto;
			}
			set
			{
				this.productoIdProducto = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idDetalle != null ? idDetalle.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is Detalle))
			{
				return false;
			}
			Detalle other = (Detalle) @object;
			if ((this.idDetalle == null && other.idDetalle != null) || (this.idDetalle != null && !this.idDetalle.Equals(other.idDetalle)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return "dto.clases.Detalle[ idDetalle=" + idDetalle + " ]";
		}

	}

}