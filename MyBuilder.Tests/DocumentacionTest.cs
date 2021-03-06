﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyBuilder.Tests
{
    [TestFixture]
    public class DocumentacionTest
    {
        [Test]
        public void PuedoGenerarDocumentacionPdf()
        {
            Documentacion documentacion = new DocumentacionPdf();

            documentacion.Agregar("<PDF>Documentacion PDF</PDF>");

            Assert.AreEqual(1, documentacion.ObtenerDocumentos().Count);
        }

        [Test]
        public void NoPuedoGenerarDocumentacionPdfsiNoEsPdf()
        {
            Documentacion documentacion = new DocumentacionPdf();

            documentacion.Agregar("no es pdf");

            Assert.AreEqual(0, documentacion.ObtenerDocumentos().Count);
        }

        [Test]
        public void PuedoGenerarUnDocumentoHtml()
        {
            Documentacion documentacion = new DocumentacionHtml();

            documentacion.Agregar("<HTML>Documentacion HTML</HTML>");

            Assert.AreEqual(1, documentacion.ObtenerDocumentos().Count);
        }

        [Test]
        public void NoPuedoGenerarUnDocumentoHtmlsiNoEsHtml()
        {
            Documentacion documentacion = new DocumentacionHtml();

            documentacion.Agregar("no es html");

            Assert.AreEqual(0, documentacion.ObtenerDocumentos().Count);
        }
    }
}
