using CVDentalSteticSystem.BLL;
using CVDentalSteticSystem.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Pages.Reportes
{
    public class UsuariosReport
    {
        int columnas = 5;

        Document document = new Document();
        PdfPTable pdfTable;
        PdfPCell pdfCell = new PdfPCell();
        Font fontStyle, fontFecha, fontTitulo;

        MemoryStream memoryStream = new MemoryStream();

        List<Usuarios> listaUsuarios = UsuariosBLL.GetUsuarios();

        public byte[] Reporte()
        {
            document = new Document(PageSize.Letter, 15f, 15f, 20f, 20f);
            pdfTable = new PdfPTable(columnas);

            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            fontStyle = FontFactory.GetFont("Calibri", 8f, 1);

            PdfWriter.GetInstance(document, memoryStream);
            document.Open();

            float[] anchoColumnas = new float[columnas];

            anchoColumnas[0] = 50; //Esta sera la fila 1 Paciente id
            anchoColumnas[1] = 60; //Esta sera la fila 2 Nombres
            anchoColumnas[2] = 70; //Esta sera la fila 3 Apellidos
            anchoColumnas[3] = 100; //Esta sera la fila 4 Direccion
            anchoColumnas[4] = 80; //Telefono


            pdfTable.SetWidths(anchoColumnas);

            this.ReportHeader();
            this.ReportBody();

            pdfTable.HeaderRows = 1;
            document.Add(pdfTable);
            document.Close();

            return memoryStream.ToArray();
        }
        private void ReportHeader()
        {
            pdfCell = new PdfPCell(this.setPageTitle());
            pdfCell.Colspan = columnas;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();
        }

        private PdfPTable setPageTitle()
        {
            PdfPTable pdfTable = new PdfPTable(2);

            fontStyle = FontFactory.GetFont("Calibri", 18f, 1);
            fontFecha = FontFactory.GetFont("Calibri", 10f, 1);
            fontTitulo = FontFactory.GetFont("Calibri", 25f, 1);

            pdfCell = new PdfPCell(new Phrase("J&N Dental Clinic", fontTitulo));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Colspan = 2;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            pdfCell = new PdfPCell(new Phrase("Reporte de Usuarios", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Colspan = 2;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();



            pdfCell = new PdfPCell(new Phrase(DateTime.Now.ToString("MM/dd/yyyy H:mm tt"), fontFecha));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Colspan = 2;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            //Una fila en blanco
            pdfCell = new PdfPCell(new Phrase(" ", fontStyle));
            pdfCell.Colspan = 2;
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            return pdfTable;
        }

        private void ReportBody()
        {
            fontStyle = FontFactory.GetFont("Calibri", 9f, 1);
            var _fontStyle = FontFactory.GetFont("Calibri", 9f, 0);

            #region Table Header
            pdfCell = new PdfPCell(new Phrase("ID", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LightGray;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Nombres", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LightGray;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Nombre de Usuario", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LightGray;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Nivel de Acceso", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LightGray;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Fecha de Registro", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LightGray;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();
            #endregion

            #region Table Body
            int num = 0;

            foreach (var item in listaUsuarios)
            {
                num++;
                pdfCell = new PdfPCell(new Phrase(item.UsuarioId.ToString(), _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.White;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.Nombres, _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.White;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.Usuario, _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.White;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.NivelAcceso, _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.White;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.Fecha.ToString("dd/MM/yyyy"), _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.White;
                pdfTable.AddCell(pdfCell);

                pdfTable.CompleteRow();
            }

            pdfCell = new PdfPCell(new Phrase(num++.ToString(), fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.White;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase(" ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.White;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase(" ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.White;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase(" ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.White;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase(" ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.White;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();
            #endregion
        }
    }
}
