//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

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
//ORIGINAL LINE: @Entity @Table(name = "cliente") @XmlRootElement @NamedQueries({ @NamedQuery(name = "Cliente.findAll", query = "SELECT c FROM Cliente c"), @NamedQuery(name = "Cliente.findByIdCliente", query = "SELECT c FROM Cliente c WHERE c.idCliente = :idCliente"), @NamedQuery(name = "Cliente.findByRut", query = "SELECT c FROM Cliente c WHERE c.rut = :rut"), @NamedQuery(name = "Cliente.findByDv", query = "SELECT c FROM Cliente c WHERE  c.dv = :dv"), @NamedQuery(name = "Cliente.findByRutDv", query = "SELECT c FROM Cliente c WHERE c.rut = :rut and c.dv = :dv"), @NamedQuery(name = "Cliente.findByNombreCliente", query = "SELECT c FROM Cliente c WHERE c.nombreCliente = :nombreCliente"), @NamedQuery(name = "Cliente.findByApellidoCliente", query = "SELECT c FROM Cliente c WHERE c.apellidoCliente = :apellidoCliente"), @NamedQuery(name = "Cliente.findBySexo", query = "SELECT c FROM Cliente c WHERE c.sexo = :sexo"), @NamedQuery(name = "Cliente.findByActivoC", query = "SELECT c FROM Cliente c WHERE c.activoC = :activoC"), @NamedQuery(name = "Cliente.findByEdadCliente", query = "SELECT c FROM Cliente c WHERE c.edadCliente = :edadCliente")}) public class Cliente implements java.io.Serializable
	[Serializable]
	public class Cliente
	{

		private const long serialVersionUID = 1L;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Id @GeneratedValue(strategy = javax.persistence.GenerationType.IDENTITY) @Basic(optional = false) @Column(name = "id_cliente") private System.Nullable<short> idCliente;
		private short? idCliente;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "rut") private int rut;
		private int rut;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 1) @Column(name = "dv") private String dv;
		private string dv;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "nombre_cliente") private String nombreCliente;
		private string nombreCliente;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Size(min = 1, max = 25) @Column(name = "apellido_cliente") private String apellidoCliente;
		private string apellidoCliente;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "sexo") private boolean sexo;
		private bool sexo;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "activo_c") private boolean activoC;
		private bool activoC;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Basic(optional = false) @NotNull @Column(name = "edad_cliente") private short edadCliente;
		private short edadCliente;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @JoinColumn(name = "estado_civil_id_estado_civil", referencedColumnName = "id_estado_civil") @ManyToOne(optional = false) private EstadoCivil estadoCivilIdEstadoCivil;
		private EstadoCivil estadoCivilIdEstadoCivil;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @OneToMany(cascade = javax.persistence.CascadeType.ALL, mappedBy = "clienteIdCliente") private java.util.List<Ventas> ventasList;
		private IList<Ventas> ventasList;

		public Cliente()
		{
		}

		public Cliente(short? idCliente)
		{
			this.idCliente = idCliente;
		}

		public Cliente(short? idCliente, int rut, string dv, string nombreCliente, string apellidoCliente, bool sexo, bool activoC, short edadCliente)
		{
			this.idCliente = idCliente;
			this.rut = rut;
			this.dv = dv;
			this.nombreCliente = nombreCliente;
			this.apellidoCliente = apellidoCliente;
			this.sexo = sexo;
			this.activoC = activoC;
			this.edadCliente = edadCliente;
		}

		public virtual short? IdCliente
		{
			get
			{
				return idCliente;
			}
			set
			{
				this.idCliente = value;
			}
		}


		public virtual int Rut
		{
			get
			{
				return rut;
			}
			set
			{
				this.rut = value;
			}
		}


		public virtual string Dv
		{
			get
			{
				return dv;
			}
			set
			{
				this.dv = value;
			}
		}


		public virtual string NombreCliente
		{
			get
			{
				return nombreCliente;
			}
			set
			{
				this.nombreCliente = value;
			}
		}


		public virtual string ApellidoCliente
		{
			get
			{
				return apellidoCliente;
			}
			set
			{
				this.apellidoCliente = value;
			}
		}


		public virtual bool Sexo
		{
			get
			{
				return sexo;
			}
			set
			{
				this.sexo = value;
			}
		}


		public virtual bool ActivoC
		{
			get
			{
				return activoC;
			}
			set
			{
				this.activoC = value;
			}
		}


		public virtual short EdadCliente
		{
			get
			{
				return edadCliente;
			}
			set
			{
				this.edadCliente = value;
			}
		}


		public virtual EstadoCivil EstadoCivilIdEstadoCivil
		{
			get
			{
				return estadoCivilIdEstadoCivil;
			}
			set
			{
				this.estadoCivilIdEstadoCivil = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @XmlTransient public java.util.List<Ventas> getVentasList()
		public virtual IList<Ventas> VentasList
		{
			get
			{
				return ventasList;
			}
			set
			{
				this.ventasList = value;
			}
		}


		public override int GetHashCode()
		{
			int hash = 0;
			hash += (idCliente != null ? idCliente.GetHashCode() : 0);
			return hash;
		}

		public override bool Equals(object @object)
		{
			// TODO: Warning - this method won't work in the case the id fields are not set
			if (!(@object is Cliente))
			{
				return false;
			}
			Cliente other = (Cliente) @object;
			if ((this.idCliente == null && other.idCliente != null) || (this.idCliente != null && !this.idCliente.Equals(other.idCliente)))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{

//====================================================================================================
//End of the allowed output for the Free Edition of Java to C# Converter.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================
