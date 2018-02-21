<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Cotización de Vehículo</h2>
        <table>
          <tr bgcolor="#fafad2">
            <th colspan="2">Agencia</th>
          </tr>
          <tr>
            <td colspan="2" align="center">
              <xsl:value-of select="VehiculosAgencias/Agencia/@Nombre"/>
            </td>
          </tr>
          
          <tr bgcolor="#fafad2">
            <th colspan="2">Cliente</th>
          </tr>
          <tr>
            <td>Email:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Cliente/Email"/>
            </td>
          </tr>
          <tr>
            <td>Teléfono</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Cliente/Telefono"/>
            </td>
          </tr>
         
          <tr bgcolor="#fafad2">
            <th colspan="2">Vehículo</th>
          </tr>
          <tr>
            <td>Combustible:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Vehiculo/@Combustible"/>
            </td>
          </tr>
          <tr>
            <td>Transmisión:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Vehiculo/@Transmision"/>
            </td>
          </tr>
          <tr>
            <td>Categoría:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Vehiculo/Categoria"/>
            </td>
          </tr>
          <tr>
            <td>Precio base:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Vehiculo/PrecioBase"/>
            </td>
          </tr>
          
          <tr bgcolor="#fafad2">
            <th colspan="2">Extras</th>
          </tr>
          <xsl:for-each select="VehiculosAgencias/Vehiculo/Extras/Extra">
            <tr>
              <td>
                <xsl:value-of select="./@Descripcion"/>
              </td>
              <td>
                <xsl:value-of select="./@Costo"/>
              </td>
            </tr>
          </xsl:for-each>

          <tr bgcolor="#fafad2">
            <th colspan="2">Cotización</th>
          </tr>
          <tr>
            <td>Cuota mensual:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Cotizacion/CuotaMensual"/>
            </td>
          </tr>
          <tr>
            <td>Meses:</td>
            <td>
              <xsl:value-of select="VehiculosAgencias/Cotizacion/Meses"/>
            </td>
          </tr>
          <tr bgcolor="#fafad2">
            <th colspan="2">Pagos</th>
          </tr>
          <xsl:for-each select="VehiculosAgencias/Pagos/Pago">
            <tr>
              <td>
                Mes: <xsl:value-of select="./@Mes"/>
              </td>
              <td>
                Monto: <xsl:value-of select="./@Monto"/>
              </td>
            </tr>
          </xsl:for-each>
          
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>