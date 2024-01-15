using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GST_INVOICE
{
    class GeneratePDF
    {
        public static void Generate(int invoice_number){
           // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());

            string query = "select  * from tbl_company where c_id="+LoginInfo.loginId+"" ;
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open();
            adpt.Fill(dt);
            con.Close();

            string inv_query = "select * from tbl_invoice" + LoginInfo.loginId + "  join tbl_client" + LoginInfo.loginId + "  on tbl_invoice" + LoginInfo.loginId + " .inv_cid= tbl_client" + LoginInfo.loginId + " .cl_id join tbl_state on tbl_client" + LoginInfo.loginId + " .cl_code=tbl_state.st_code where tbl_invoice" + LoginInfo.loginId + " .invoice_no=" + invoice_number;
            DataTable inv_dt = new DataTable();
            SqlDataAdapter inv_adpt = new SqlDataAdapter(inv_query, con);

            con.Open();
            inv_adpt.Fill(inv_dt);
            con.Close();
            
            Document document = new Document(PageSize.A4, 10f, 10f, 50f, 10f);
            string newPath = @"C:\\GST Invoices\\"+dt.Rows[0]["c_name"].ToString()+"\\Bills\\";
            if (!Directory.Exists(newPath))
            {
                System.IO.Directory.CreateDirectory(newPath);
            }
            PdfWriter.GetInstance(document, new FileStream(newPath + "/ Inv " + inv_dt.Rows[0]["invoice_no"].ToString() + "_" +Convert.ToDateTime(inv_dt.Rows[0]["inv_date"]).ToString("ddMMMyy")+ "_" + inv_dt.Rows[0]["cl_name"].ToString() + "_" + inv_dt.Rows[0]["cl_gstin"].ToString() + ".pdf", FileMode.Create));

            document.Open();
            BaseFont address_fnt = BaseFont.CreateFont(
                  BaseFont.TIMES_ROMAN,
                  BaseFont.CP1250,
                  BaseFont.EMBEDDED);
            iTextSharp.text.Font address_font = new iTextSharp.text.Font(address_fnt, 10);

            BaseFont smallbf = BaseFont.CreateFont(
                   BaseFont.TIMES_ROMAN,
                   BaseFont.CP1250,
                   BaseFont.EMBEDDED);
            iTextSharp.text.Font smallfont = new iTextSharp.text.Font(smallbf, 8);

            BaseFont Bsmallbf = BaseFont.CreateFont(

                   BaseFont.TIMES_ROMAN,
                   BaseFont.CP1250,
                   BaseFont.EMBEDDED);
            iTextSharp.text.Font Bsmallfont = new iTextSharp.text.Font(Bsmallbf, 9);
            if (dt.Rows.Count > 0)
            {
                PdfPTable table = new PdfPTable(3);
                table.TotalWidth = 550f;
                table.LockedWidth = true;

                float[] widths = { 50f, 300f, 150f };
                table.SetWidths(widths);
                PdfPCell logo=new PdfPCell ();
                if (dt.Rows[0]["c_logo"].ToString().Contains("\\"))
                {
                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(dt.Rows[0]["c_logo"].ToString());
                    jpg.ScaleAbsolute(50f, 50f);
                    logo = new PdfPCell(jpg);
                    
                }
                else {
                    logo = new PdfPCell(new Phrase("", address_font));
                }
                
                
                logo.Rowspan = 3;
                logo.PaddingLeft = 10f;
                logo.HorizontalAlignment = Element.ALIGN_CENTER;
                logo.VerticalAlignment = Element.ALIGN_MIDDLE;
                logo.BorderWidthRight = 0;
                logo.PaddingBottom = 10f;
                logo.BorderWidthBottom = 0;
                table.AddCell(logo);
                BaseFont bf = BaseFont.CreateFont(
                        BaseFont.TIMES_BOLD,
                        BaseFont.CP1250,
                        BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 18);
                PdfPCell company = new PdfPCell(new Phrase((dt.Rows[0]["c_name"].ToString()), font));
                company.HorizontalAlignment = Element.ALIGN_CENTER;
                company.PaddingLeft = 60f;
                company.BorderWidthLeft = 0;
                company.BorderWidthRight = 0;
                company.BorderWidthBottom = 0;
                table.AddCell(company);





                PdfPCell mob = new PdfPCell(new Phrase("Mob. " + dt.Rows[0]["c_mob"].ToString(), address_font));
                mob.BorderWidthBottom = 0;
                mob.BorderWidthLeft = 0;
                mob.HorizontalAlignment = Element.ALIGN_CENTER;
                mob.VerticalAlignment = Element.ALIGN_BOTTOM;
                table.AddCell(mob);



                PdfPCell deal_with = new PdfPCell(new Phrase(dt.Rows[0]["c_deal"].ToString(), address_font));
                deal_with.HorizontalAlignment = Element.ALIGN_CENTER;
                deal_with.PaddingLeft = 60f;
                deal_with.BorderWidth = 0;
                table.AddCell(deal_with);

                PdfPCell mail = new PdfPCell(new Phrase("E-mail: " + dt.Rows[0]["c_mail"].ToString(), address_font));
                mail.HorizontalAlignment = Element.ALIGN_CENTER;
                mail.VerticalAlignment = Element.ALIGN_TOP;
                mail.BorderWidthLeft = 0;
                mail.BorderWidthBottom = 0;
                mail.BorderWidthTop = 0;
                table.AddCell(mail);

                PdfPCell address = new PdfPCell(new Phrase(dt.Rows[0]["c_address"].ToString(), address_font));
                address.HorizontalAlignment = Element.ALIGN_CENTER;
                address.PaddingLeft = 60f;
                address.BorderWidth = 0;
                address.PaddingBottom = 10f;
                table.AddCell(address);

                PdfPCell gstin = new PdfPCell(new Phrase("GSTIN: " + dt.Rows[0]["c_gst"].ToString(), address_font));
                gstin.HorizontalAlignment = Element.ALIGN_CENTER;
                gstin.VerticalAlignment = Element.ALIGN_TOP;
                gstin.BorderWidthLeft = 0;
                gstin.BorderWidthBottom = 0;
                gstin.PaddingBottom = 10f;
                gstin.BorderWidthTop = 0;
                table.AddCell(gstin);
                table.SplitLate = false;
                table.SplitRows = true;

                document.Add(table);

            }

            if (inv_dt.Rows.Count > 0)
            {

                PdfPTable body = new PdfPTable(5);
                body.TotalWidth = 550f;
                body.LockedWidth = true;
                // float[] b_width = { 130f, 20f, 230f, 20f, 150f };
                // body.SetWidths(b_width);
                BaseFont invbf = BaseFont.CreateFont(
                       BaseFont.TIMES_BOLD,
                       BaseFont.CP1250,
                       BaseFont.EMBEDDED);
                iTextSharp.text.Font invfont = new iTextSharp.text.Font(invbf, 13);
                //row 1
                string invoice_num = "N/A";
                if ((Convert.ToInt16(inv_dt.Rows[0]["invoice_no"].ToString()) < 10))
                {
                    invoice_num = "00" + Convert.ToString(Convert.ToInt16(inv_dt.Rows[0]["invoice_no"].ToString()));
                }
                else if ((Convert.ToInt16(inv_dt.Rows[0]["invoice_no"].ToString()) < 100)) { invoice_num = "0" + Convert.ToString(Convert.ToInt16(inv_dt.Rows[0]["invoice_no"].ToString())); }
                else { invoice_num = Convert.ToString(Convert.ToInt16(inv_dt.Rows[0]["invoice_no"].ToString())); }

                PdfPCell invoice_no = new PdfPCell(new Phrase("Invoice No : " + invoice_num, invfont));
                invoice_no.Colspan = 2;
                invoice_no.BorderWidthRight = 0;
                invoice_no.BorderWidthBottom = 0;
                //invoice_no.PaddingTop = 30f;
                body.AddCell(invoice_no);

                PdfPCell title = new PdfPCell(new Phrase(dt.Rows[0]["inv_type"].ToString(), invfont));
                title.HorizontalAlignment = Element.ALIGN_CENTER;
                title.BorderWidthLeft = 0;
                title.BorderWidthBottom = 0;
                title.BorderWidthRight = 0;
                //title.PaddingTop = 30f;
                title.VerticalAlignment = Element.ALIGN_CENTER;
                body.AddCell(title);

                PdfPCell date = new PdfPCell(new Phrase(Convert.ToDateTime(inv_dt.Rows[0]["inv_date"]).ToString("dd MMM yyyy"), invfont));
                date.Colspan = 2;
                //ship_add.BorderWidthTop = 0;
                date.HorizontalAlignment = Element.ALIGN_RIGHT;
                date.BorderWidthLeft = 0;
                date.BorderWidthBottom = 0;
                //date.BorderWidthRight = 0;
                //date.PaddingTop = 30f;
                //date.HorizontalAlignment = Element.ALIGN_CENTER;
                date.VerticalAlignment = Element.ALIGN_CENTER;
                body.AddCell(date);


                //row 2
                PdfPCell bil_add = new PdfPCell(new Phrase("Billing Address:-", address_font));
                bil_add.Colspan = 4;
                bil_add.BorderWidthTop = 0;
                bil_add.BorderWidthRight = 0;
                bil_add.BorderWidthBottom = 0;
                body.AddCell(bil_add);

                //PdfPCell ship_add = new PdfPCell(new Phrase("Shipping Address:-", address_font));
                PdfPCell ship_add = new PdfPCell(new Phrase(" ", address_font));
               // ship_add.Colspan = 1;
                ship_add.BorderWidthTop = 0;
                ship_add.BorderWidthLeft = 0;
                ship_add.BorderWidthBottom = 0;
                body.AddCell(ship_add);


                //row 3 
                PdfPCell cust_name = new PdfPCell(new Phrase("Cust. Name :-" + inv_dt.Rows[0]["cl_name"].ToString(), address_font));
                cust_name.Colspan = 4;
                cust_name.BorderWidthTop = 0;
                cust_name.BorderWidthRight = 0;
                cust_name.BorderWidthBottom = 0;
                body.AddCell(cust_name);

                //PdfPCell con_name = new PdfPCell(new Phrase("Client Name:-" + inv_dt.Rows[0]["cl_name"].ToString(), address_font));
                PdfPCell con_name = new PdfPCell(new Phrase(" ", address_font));
                con_name.Colspan = 1;
                con_name.BorderWidthTop = 0;
                con_name.BorderWidthLeft = 0;
                con_name.BorderWidthBottom = 0;
                body.AddCell(con_name);


                //rows 4

                PdfPCell cust_mob = new PdfPCell(new Phrase("Mob :-" + inv_dt.Rows[0]["cl_contact"].ToString(), address_font));
                cust_mob.Colspan = 4;
                cust_mob.BorderWidthTop = 0;
                cust_mob.BorderWidthRight = 0;
                cust_mob.BorderWidthBottom = 0;
                body.AddCell(cust_mob);

                //PdfPCell con_mob = new PdfPCell(new Phrase("Mob :-" + inv_dt.Rows[0]["cl_contact"].ToString(), address_font));
                PdfPCell con_mob = new PdfPCell(new Phrase(" ", address_font));
                con_mob.Colspan = 1;
                con_mob.BorderWidthTop = 0;
                con_mob.BorderWidthLeft = 0;
                con_mob.BorderWidthBottom = 0;
                body.AddCell(con_mob);


                //row 5

                PdfPCell cust_add = new PdfPCell(new Phrase("Address :-" + inv_dt.Rows[0]["cl_add"].ToString(), address_font));
                cust_add.Colspan = 4;
                cust_add.BorderWidthTop = 0;
                cust_add.BorderWidthRight = 0;
                cust_add.BorderWidthBottom = 0;
                body.AddCell(cust_add);

                //PdfPCell con_add = new PdfPCell(new Phrase("Address:-" + inv_dt.Rows[0]["cl_add"].ToString(), address_font));
                PdfPCell con_add = new PdfPCell(new Phrase(" ", address_font));
                con_add.Colspan = 1;
                con_add.BorderWidthTop = 0;
                con_add.BorderWidthLeft = 0;
                con_add.BorderWidthBottom = 0;
                body.AddCell(con_add);



                //row 5

                PdfPCell cust_state = new PdfPCell(new Phrase("State:-" + inv_dt.Rows[0]["st_name"].ToString(), address_font));
                //cust_state.Colspan = 2;
                cust_state.BorderWidthTop = 0;
                cust_state.BorderWidthRight = 0;
                cust_state.BorderWidthBottom = 0;
                body.AddCell(cust_state);

                PdfPCell cust_stcode = new PdfPCell(new Phrase("State Code:-" + inv_dt.Rows[0]["cl_code"].ToString(), address_font));
                //cust_stcode.Colspan = 2;
                cust_stcode.BorderWidth = 0;
                body.AddCell(cust_stcode);

                // PdfPCell empty = new PdfPCell(new Phrase(""));
                //body.AddCell(empty);

                //PdfPCell con_state = new PdfPCell(new Phrase("State:-" + inv_dt.Rows[0]["st_name"].ToString(), address_font));
                PdfPCell con_state = new PdfPCell(new Phrase(" ", address_font));
                con_state.Colspan = 2;
                con_state.BorderWidth = 0;
                con_state.PaddingRight = 15;
                con_state.HorizontalAlignment = Element.ALIGN_RIGHT;
                body.AddCell(con_state);

                //PdfPCell con_stcode = new PdfPCell(new Phrase("State Code:-" + inv_dt.Rows[0]["cl_code"].ToString(), address_font));
                PdfPCell con_stcode = new PdfPCell(new Phrase(" ", address_font));
                con_stcode.BorderWidthTop = 0;
                con_stcode.BorderWidthLeft = 0;
                con_stcode.BorderWidthBottom = 0;
                body.AddCell(con_stcode);

                //row 6

                PdfPCell cust_gstin = new PdfPCell(new Phrase("GSTIN:-" + inv_dt.Rows[0]["cl_gstin"].ToString(), address_font));
                cust_gstin.Colspan = 5;
                cust_gstin.BorderWidthTop = 0;
                cust_gstin.PaddingBottom = 15f;
                cust_gstin.BorderWidthBottom = 0;
                body.AddCell(cust_gstin);

                body.SplitLate = false;
                body.SplitRows = true;
                document.Add(body);


                //INVOICE TABLE

                PdfPTable invoice = new PdfPTable(15);
                invoice.TotalWidth = 550f;
                invoice.LockedWidth = true;
                float[] widths_rows = { 15f, 53f, 45f, 30f, 25f, 30f, 48f, 29f, 50f, 27f, 48f, 27f, 48f, 27f, 48f };
                invoice.SetWidths(widths_rows);
                // HEADING ROW
                PdfPCell sno = new PdfPCell(new Phrase("S.N.", Bsmallfont));
                sno.VerticalAlignment = Element.ALIGN_MIDDLE;
                invoice.AddCell(sno);
                sno.BorderWidthRight = 0;
                PdfPCell part = new PdfPCell(new Phrase("Particulars", Bsmallfont));
                part.VerticalAlignment = Element.ALIGN_MIDDLE;
                part.BorderWidthLeft = 0;
                invoice.AddCell(part);
                PdfPCell HSN = new PdfPCell(new Phrase("HSN/SAC", Bsmallfont));
                HSN.VerticalAlignment = Element.ALIGN_MIDDLE;
                HSN.BorderWidthLeft = 0;
                invoice.AddCell(HSN);
                PdfPCell qty = new PdfPCell(new Phrase("Qty.", Bsmallfont));
                qty.VerticalAlignment = Element.ALIGN_MIDDLE;
                qty.BorderWidthLeft = 0;
                invoice.AddCell(qty);
                PdfPCell uom = new PdfPCell(new Phrase("UoM", Bsmallfont));
                uom.VerticalAlignment = Element.ALIGN_MIDDLE;
                uom.BorderWidthLeft = 0;
                invoice.AddCell(uom);
                PdfPCell rate = new PdfPCell(new Phrase("Rate", Bsmallfont));
                rate.VerticalAlignment = Element.ALIGN_MIDDLE;
                rate.BorderWidthLeft = 0;
                invoice.AddCell(rate);
                PdfPCell value = new PdfPCell(new Phrase("Value", Bsmallfont));
                value.VerticalAlignment = Element.ALIGN_MIDDLE;
                value.BorderWidthLeft = 0;
                invoice.AddCell(value);
                PdfPCell disc = new PdfPCell(new Phrase("DISC", Bsmallfont));
                disc.VerticalAlignment = Element.ALIGN_MIDDLE;
                disc.BorderWidthLeft = 0;
                invoice.AddCell(disc);
                PdfPCell tax_val = new PdfPCell(new Phrase("Taxable Value", Bsmallfont));
                tax_val.VerticalAlignment = Element.ALIGN_MIDDLE;
                tax_val.BorderWidthLeft = 0;
                invoice.AddCell(tax_val);
                PdfPCell sgst = new PdfPCell(new Phrase("SGST Rate %", Bsmallfont));
                sgst.VerticalAlignment = Element.ALIGN_MIDDLE;
                sgst.BorderWidthLeft = 0;
                invoice.AddCell(sgst);
                PdfPCell sgst_amt = new PdfPCell(new Phrase("SGST Amount", Bsmallfont));
                sgst_amt.VerticalAlignment = Element.ALIGN_MIDDLE;
                sgst_amt.BorderWidthLeft = 0;
                invoice.AddCell(sgst_amt);
                PdfPCell cgst = new PdfPCell(new Phrase("CGST Rate %", Bsmallfont));
                cgst.VerticalAlignment = Element.ALIGN_MIDDLE;
                cgst.BorderWidthLeft = 0;
                invoice.AddCell(cgst);
                PdfPCell cgst_amt = new PdfPCell(new Phrase("CGST Amount", Bsmallfont));
                cgst_amt.VerticalAlignment = Element.ALIGN_MIDDLE;
                cgst_amt.BorderWidthLeft = 0;
                invoice.AddCell(cgst_amt);
                PdfPCell igst = new PdfPCell(new Phrase("IGST Rate %", Bsmallfont));
                igst.VerticalAlignment = Element.ALIGN_MIDDLE;
                igst.BorderWidthLeft = 0;
                invoice.AddCell(igst);
                PdfPCell igst_amt = new PdfPCell(new Phrase("IGST Amount", Bsmallfont));
                igst_amt.VerticalAlignment = Element.ALIGN_MIDDLE;
                igst_amt.BorderWidthLeft = 0;
                invoice.AddCell(igst_amt);

                for (int i = 0; i < inv_dt.Rows.Count; i++)
                {
                    PdfPCell sno_data = new PdfPCell(new Phrase(Convert.ToString(i + 1), smallfont));
                    sno_data.BorderWidthBottom = 0;
                    sno_data.BorderWidthTop = 0;
                    sno_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                   // sno_data.BorderWidthLeft = 0;
                    sno_data.PaddingTop = 5f;
                    sno_data.PaddingBottom = 5f;
                    invoice.AddCell(sno_data);
                    
                    PdfPCell part_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_part"].ToString(), smallfont));
                    part_data.BorderWidthLeft = 0;
                    part_data.PaddingTop = 5f;
                    part_data.PaddingBottom = 5f;
                    part_data.BorderWidthBottom = 0;
                    part_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    part_data.BorderWidthTop = 0;
                    invoice.AddCell(part_data);
                    PdfPCell HSN_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_hsn"].ToString(), smallfont));
                    HSN_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    HSN_data.BorderWidthLeft = 0;
                    HSN_data.PaddingTop = 5f;
                    HSN_data.PaddingBottom = 5f;
                    HSN_data.BorderWidthTop = 0;

                    HSN_data.BorderWidthBottom = 0;
                    HSN_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(HSN_data);
                    PdfPCell qty_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_qty"].ToString(), smallfont));
                    qty_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    qty_data.BorderWidthLeft = 0;
                    qty_data.PaddingTop = 5f;
                    qty_data.PaddingBottom = 5f;
                    qty_data.BorderWidthTop = 0;
                    qty_data.BorderWidthBottom = 0;
                    qty_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(qty_data);
                    PdfPCell uom_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_unit"].ToString(), smallfont));
                    uom_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    uom_data.BorderWidthLeft = 0;
                    uom_data.PaddingTop = 5f;
                    uom_data.PaddingBottom = 5f;
                    uom_data.BorderWidthTop = 0;
                    uom_data.BorderWidthBottom = 0;
                    uom_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(uom_data);
                    PdfPCell rate_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_rate"].ToString(), smallfont));
                    rate_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    rate_data.BorderWidthLeft = 0;
                    rate_data.PaddingTop = 5f;
                    rate_data.PaddingTop = 5f;
                    rate_data.BorderWidthTop = 0;
                    rate_data.BorderWidthBottom = 0;
                    rate_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(rate_data);
                    PdfPCell value_data = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[i]["inv_value"].ToString()), 2).ToString("N2"), smallfont));
                    value_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    value_data.BorderWidthLeft = 0;
                    value_data.PaddingTop = 5f;
                    value_data.PaddingBottom= 5f;
                    value_data.BorderWidthTop = 0;
                    value_data.BorderWidthBottom = 0;
                    value_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(value_data);
                    PdfPCell disc_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_disc"].ToString(), smallfont));
                    disc_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    disc_data.BorderWidthLeft = 0;
                    disc_data.PaddingTop = 5f;
                    disc_data.PaddingBottom = 5f;
                    disc_data.BorderWidthTop = 0;
                    disc_data.BorderWidthBottom = 0;
                    disc_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(disc_data);
                    PdfPCell tax_val_data = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[i]["inv_tax_val"].ToString()), 2).ToString("N2"), smallfont));
                    tax_val_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tax_val_data.BorderWidthLeft = 0;
                    tax_val_data.PaddingTop = 5f;
                    tax_val_data.PaddingTop = 5f;
                    tax_val_data.BorderWidthTop = 0;
                    tax_val_data.BorderWidthBottom = 0;
                    tax_val_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(tax_val_data);
                    PdfPCell sgst_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_sgst_rate"].ToString(), smallfont));
                    sgst_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    sgst_data.BorderWidthLeft = 0;
                    sgst_data.PaddingTop = 5f;
                    sgst_data.PaddingBottom = 5f;
                    sgst_data.BorderWidthTop = 0;
                    sgst_data.BorderWidthBottom = 0;
                    sgst_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(sgst_data);

                    PdfPCell sgst_amt_data = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[i]["inv_sgst_amt"].ToString()), 2).ToString("N2"), smallfont));
                    sgst_amt_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    sgst_amt_data.BorderWidthLeft = 0;
                    sgst_amt_data.PaddingTop = 5f;
                    sgst_amt_data.PaddingBottom = 5f;
                    sgst_amt_data.BorderWidthTop = 0;
                    sgst_amt_data.BorderWidthBottom = 0;
                    sgst_amt_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(sgst_amt_data);
                    PdfPCell cgst_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_cgst_rate"].ToString(), smallfont));
                    cgst_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cgst_data.BorderWidthLeft = 0;
                    cgst_data.PaddingTop = 5f;
                    cgst_data.PaddingBottom = 5f;
                    cgst_data.BorderWidthTop = 0;
                    cgst_data.BorderWidthBottom = 0;
                    cgst_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(cgst_data);
                    PdfPCell cgst_amt_data = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[i]["inv_cgst_amt"].ToString()), 2).ToString("N2"), smallfont));
                    cgst_amt_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cgst_amt_data.BorderWidthLeft = 0;
                    cgst_amt_data.PaddingTop = 5f;
                    cgst_amt_data.PaddingBottom = 5f;
                    cgst_amt_data.BorderWidthTop = 0;
                    cgst_amt_data.BorderWidthBottom = 0;
                    cgst_amt_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(cgst_amt_data);
                    PdfPCell igst_data = new PdfPCell(new Phrase(inv_dt.Rows[i]["inv_igst_rate"].ToString(), smallfont));
                    igst_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    igst_data.BorderWidthLeft = 0;
                    igst_data.PaddingTop = 5f;
                    igst_data.PaddingBottom = 5f;
                    igst_data.BorderWidthTop = 0;
                    igst_data.BorderWidthBottom = 0;
                    igst_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(igst_data);
                    PdfPCell igst_amt_data = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[i]["inv_igst_amt"].ToString()), 2).ToString("N2"), smallfont));
                    igst_amt_data.VerticalAlignment = Element.ALIGN_MIDDLE;
                    igst_amt_data.BorderWidthLeft = 0;
                    igst_amt_data.PaddingTop = 5f;
                    igst_amt_data.PaddingBottom = 5f;
                    igst_amt_data.BorderWidthTop = 0;
                    igst_amt_data.BorderWidthBottom = 0;
                    igst_amt_data.HorizontalAlignment = Element.ALIGN_RIGHT;
                    invoice.AddCell(igst_amt_data);
                }

                PdfPCell foot_sno = new PdfPCell(new Phrase("TOTAL", smallfont));
                foot_sno.Colspan = 7;
                //foot_sno.Height = 15f;
                foot_sno.PaddingTop = 7f;
                foot_sno.PaddingBottom = 7f;
                invoice.AddCell(foot_sno);

                PdfPCell footgap = new PdfPCell(new Phrase("", smallfont));
                footgap.BorderWidthLeft = 0;
                invoice.AddCell(footgap);

                PdfPCell foot_tax_val = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_befor_tax"].ToString()), 2).ToString("N2"), smallfont));
                foot_tax_val.HorizontalAlignment = Element.ALIGN_RIGHT;
                foot_tax_val.PaddingTop = 7f;
                foot_tax_val.PaddingBottom = 7f;
                //foot_tax_val.BorderWidthRight = 0;
                foot_tax_val.BorderWidthLeft = 0;
                invoice.AddCell(foot_tax_val);


                PdfPCell foot_sgst = new PdfPCell(new Phrase("", smallfont));
                foot_sgst.BorderWidthRight = 0;
                foot_sgst.BorderWidthLeft = 0;
                //foot_sgst.HorizontalAlignment = Element.ALIGN_RIGHT;
                invoice.AddCell(foot_sgst);
                PdfPCell foot_sgst_amt = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_total_gst"].ToString()), 2).ToString("N2"), smallfont));
                //foot_sgst_amt.BorderWidthRight = 0;
                foot_sgst_amt.BorderWidthLeft = 0;
                foot_sgst_amt.PaddingTop = 7f;
                foot_sgst_amt.PaddingBottom = 7f;
                foot_sgst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                invoice.AddCell(foot_sgst_amt);


                PdfPCell foot_cgst = new PdfPCell(new Phrase("", smallfont));
                //foot_cgst.BorderWidthRight = 0;
                foot_cgst.BorderWidthLeft = 0;
                //foot_tax_val.HorizontalAlignment = Element.ALIGN_RIGHT;
                invoice.AddCell(foot_cgst);
                PdfPCell foot_cgst_amt = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_total_cgst"].ToString()), 2).ToString("N2"), smallfont));
               // foot_cgst_amt.BorderWidthRight = 0;
                foot_cgst_amt.BorderWidthLeft = 0;
                foot_cgst_amt.PaddingTop = 7f;
                foot_cgst_amt.PaddingBottom = 7f;
                foot_cgst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                invoice.AddCell(foot_cgst_amt);

                PdfPCell foot_igst = new PdfPCell(new Phrase("", smallfont));
                //foot_igst.BorderWidthRight = 0;
                foot_igst.BorderWidthLeft = 0;
                invoice.AddCell(foot_igst);
                PdfPCell foot_igst_amt = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_total_igst"].ToString()), 2).ToString("N2"), smallfont));
                foot_igst_amt.BorderWidthLeft = 0;
                foot_igst_amt.PaddingTop = 7f;
                foot_igst_amt.PaddingBottom = 7f;
                foot_igst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                invoice.AddCell(foot_igst_amt);
                invoice.SplitLate = false;
                invoice.SplitRows = true;
                document.Add(invoice);


                //FOOTER DESCRIPTION

                //row 1
                PdfPTable footer = new PdfPTable(4);
                footer.TotalWidth = 550f;
                footer.LockedWidth = true;
                PdfPCell ttl_amt = new PdfPCell(new Phrase("Total Amount in Words ", smallfont));
                //ttl_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                ttl_amt.PaddingTop = 10f;
                ttl_amt.Colspan = 2;
                ttl_amt.BorderWidthBottom = 0;
               // ttl_amt.BorderWidthRight = 0;
                footer.AddCell(ttl_amt);

                PdfPCell tot_bef_tax = new PdfPCell(new Phrase("Total Before Tax", smallfont));
                //tot_bef_tax.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_bef_tax.PaddingTop = 10f;
                tot_bef_tax.PaddingLeft= 10f;
                tot_bef_tax.BorderWidthBottom = 0;
                tot_bef_tax.BorderWidthRight = 0;
                tot_bef_tax.BorderWidthLeft = 0;

                footer.AddCell(tot_bef_tax);

                PdfPCell tot_amt_bef_tax = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_befor_tax"].ToString()), 2).ToString("N2"), smallfont));
                tot_amt_bef_tax.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_amt_bef_tax.PaddingTop = 10f;
                tot_amt_bef_tax.BorderWidthBottom = 0;
                tot_amt_bef_tax.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_amt_bef_tax.BorderWidthLeft = 0;
                //tot_amt_bef_tax.BorderWidthTop = 0;
                footer.AddCell(tot_amt_bef_tax);

                //row 2
                PdfPCell amt_word = new PdfPCell(new Phrase(num_to_words.convert_number(Convert.ToDouble(inv_dt.Rows[0]["inv_grand_total"].ToString())), smallfont));
                amt_word.PaddingTop = 5f;
                amt_word.Colspan = 2;
                amt_word.Rowspan = 2;
                amt_word.BorderWidthTop = 0;
                amt_word.BorderWidthBottom = 0;
                //amt_word.BorderWidthRight = 1;
                footer.AddCell(amt_word);

                PdfPCell tot_sgst = new PdfPCell(new Phrase("Total SGST", smallfont));
                tot_sgst.PaddingTop = 5f;
                tot_sgst.PaddingLeft= 10f;
                tot_sgst.BorderWidth = 0;
                footer.AddCell(tot_sgst);

                PdfPCell tot_sgst_amt = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_total_gst"].ToString()), 2).ToString("N2"), smallfont));
                tot_sgst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_sgst_amt.PaddingTop = 5f;
                tot_sgst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_sgst_amt.BorderWidthBottom = 0;
                tot_sgst_amt.BorderWidthLeft = 0;
                tot_sgst_amt.BorderWidthTop = 0;
                footer.AddCell(tot_sgst_amt);
                //row 3
              
                PdfPCell tot_cgst = new PdfPCell(new Phrase("Total CGST", smallfont));
                tot_cgst.PaddingTop = 5f;
                tot_cgst.PaddingLeft = 10f;
                tot_cgst.BorderWidth = 0;
                footer.AddCell(tot_cgst);

                PdfPCell tot_cgst_amt = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_total_cgst"].ToString()), 2).ToString("N2"), smallfont));
                tot_cgst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_cgst_amt.PaddingTop = 5f;
                tot_cgst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_cgst_amt.BorderWidthBottom = 0;
                tot_cgst_amt.BorderWidthLeft = 0;
                tot_cgst_amt.BorderWidthTop = 0;
                footer.AddCell(tot_cgst_amt);




                BaseFont smallinfo = BaseFont.CreateFont(
                 BaseFont.TIMES_BOLD,
              
                 BaseFont.CP1250,
                 BaseFont.EMBEDDED);
                iTextSharp.text.Font infofont = new iTextSharp.text.Font(smallinfo, 8,iTextSharp.text.Font.UNDERLINE);
                //infofont.Style = iTextSharp.text.Font.UNDERLINE;

                PdfPCell banking_info = new PdfPCell(new Phrase("Banking details ", infofont));
                // acc_name.Border = 0;
               // banking_info.BorderWidthRight = 0;
                banking_info.BorderWidthBottom = 0;
                banking_info.BorderWidthTop = 0;
                banking_info.Colspan = 2;
                //banking_info.PaddingLeft = 10f;
                footer.AddCell(banking_info);

                PdfPCell tot_igst = new PdfPCell(new Phrase("Total IGST", smallfont));
                tot_igst.PaddingTop = 5f;
                tot_igst.PaddingLeft = 10f;
                tot_igst.BorderWidth = 0;
                footer.AddCell(tot_igst);
                PdfPCell tot_igst_amt = new PdfPCell(new Phrase(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_total_igst"].ToString()), 2).ToString("N2"), smallfont));
                tot_igst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_igst_amt.PaddingTop = 5;
                tot_igst_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tot_igst_amt.BorderWidthBottom = 0;
                tot_igst_amt.BorderWidthLeft = 0;
                tot_igst_amt.BorderWidthTop = 0;
                footer.AddCell(tot_igst_amt);



                PdfPCell acc_name = new PdfPCell(new Phrase("A/c Name", smallfont));
               // acc_name.Border = 0;
                acc_name.BorderWidthRight= 0;
                acc_name.BorderWidthBottom = 0;
                acc_name.BorderWidthTop= 0;
                //acc_name.PaddingLeft = 50f;
                footer.AddCell(acc_name);
                PdfPCell getacc_name = new PdfPCell(new Phrase(dt.Rows[0]["account_name"].ToString(), smallfont));
                getacc_name.BorderWidthBottom = 0;
                getacc_name.BorderWidthTop = 0;
                getacc_name.BorderWidthLeft = 0;
                //getacc_name.PaddingRight = 100f;
                footer.AddCell(getacc_name);


                PdfPCell round_off = new PdfPCell(new Phrase("Round off", smallfont));
                //round_off.HorizontalAlignment = Element.ALIGN_RIGHT;
                round_off.PaddingTop = 5f;
                round_off.PaddingLeft = 10f;
                round_off.BorderWidth = 0;
                footer.AddCell(round_off);
                PdfPCell round_off_amt = new PdfPCell(new Phrase(inv_dt.Rows[0]["inv_other_charge"].ToString(), smallfont));
                round_off_amt.PaddingTop = 5;
                round_off_amt.HorizontalAlignment = Element.ALIGN_RIGHT;
                round_off_amt.BorderWidthBottom = 0;
                round_off_amt.BorderWidthLeft = 0;
                round_off_amt.BorderWidthTop = 0;
                footer.AddCell(round_off_amt);

                BaseFont grandtotal = BaseFont.CreateFont(

                  BaseFont.TIMES_BOLD,
                  BaseFont.CP1250,
                  BaseFont.EMBEDDED);
                iTextSharp.text.Font grandtotalf= new iTextSharp.text.Font(Bsmallbf, 10);
                PdfPCell acc_no = new PdfPCell(new Phrase("A/c No.", smallfont));
                acc_no.BorderWidthRight = 0;
                acc_no.BorderWidthBottom = 0;
                acc_no.BorderWidthTop = 0;
               // acc_no.PaddingLeft = 50f;
                footer.AddCell(acc_no);
                PdfPCell getacc_no = new PdfPCell(new Phrase(dt.Rows[0]["acc_no"].ToString(), smallfont));
                getacc_no.BorderWidthBottom = 0;
                getacc_no.BorderWidthTop = 0;
                getacc_no.BorderWidthLeft = 0;
               // getacc_no.PaddingRight = 100f;
                footer.AddCell(getacc_no);

                PdfPCell grand = new PdfPCell(new Phrase("Grant Total", grandtotalf));
                grand.PaddingLeft = 10f;
               // grand.PaddingTop = 5f;
                grand.VerticalAlignment = Element.ALIGN_MIDDLE;
                grand.BorderWidth = 0;
                footer.AddCell(grand);
                //PdfPCell grand_total = new PdfPCell(new Phrase(String.Format("{0:N2}", Convert.ToString(Math.Round(Convert.ToDouble(inv_dt.Rows[0]["inv_grand_total"].ToString()), 2)), smallfont)));
                PdfPCell grand_total = new PdfPCell(new Phrase(Convert.ToDouble(inv_dt.Rows[0]["inv_grand_total"].ToString()).ToString("N2"), grandtotalf));
                grand_total.HorizontalAlignment = Element.ALIGN_RIGHT;
                //grand_total.PaddingTop = 5f;
                grand_total.PaddingBottom = 3f;
                grand_total.VerticalAlignment= Element.ALIGN_MIDDLE;
                grand_total.BorderWidthLeft = 0;
                footer.AddCell(grand_total);




                PdfPCell bank_name = new PdfPCell(new Phrase("Bank Name", smallfont));
                bank_name.BorderWidthRight = 0;
                bank_name.BorderWidthBottom = 0;
                bank_name.BorderWidthTop = 0;
               // bank_name.PaddingLeft = 50f;
                footer.AddCell(bank_name);
                PdfPCell getbank_name = new PdfPCell(new Phrase(dt.Rows[0]["bank_name"].ToString(), smallfont));
                getbank_name.BorderWidthBottom = 0;
                getbank_name.BorderWidthTop = 0;
                getbank_name.BorderWidthLeft = 0;
                //getbank_name.PaddingRight = 100f;
                footer.AddCell(getbank_name);


                PdfPCell gst_on_reserve = new PdfPCell(new Phrase("GST on Reserve Charge", smallfont));
                gst_on_reserve.PaddingTop = 5f;
                gst_on_reserve.PaddingLeft = 10f;
                gst_on_reserve.BorderWidth = 0;
                footer.AddCell(gst_on_reserve);

                PdfPCell gst_reserve = new PdfPCell(new Phrase(inv_dt.Rows[0]["gst_reserve"].ToString(), smallfont));
                gst_reserve.HorizontalAlignment = Element.ALIGN_RIGHT;
                gst_reserve.PaddingTop = 5;
                gst_reserve.HorizontalAlignment = Element.ALIGN_RIGHT;
                gst_reserve.BorderWidthBottom = 0;
                gst_reserve.BorderWidthLeft = 0;
                footer.AddCell(gst_reserve);


                // row 3

                PdfPCell ifsc = new PdfPCell(new Phrase("IFSC", smallfont));
                ifsc.BorderWidthRight = 0;
                ifsc.BorderWidthBottom = 0;
                ifsc.BorderWidthTop = 0;
               // ifsc.PaddingLeft = 50f;
                footer.AddCell(ifsc);
                PdfPCell getifsc = new PdfPCell(new Phrase(dt.Rows[0]["ifsc"].ToString(), smallfont));
                //getifsc.BorderWidthRight = 0;
                getifsc.BorderWidthBottom = 0;
                getifsc.BorderWidthTop = 0;
                getifsc.BorderWidthLeft = 0;
                //getifsc.PaddingRight = 100f;
                footer.AddCell(getifsc);

                PdfPCell for_company = new PdfPCell(new Phrase("M/S " + dt.Rows[0]["c_name"].ToString(), smallfont));
                for_company.PaddingTop = 20f;
                for_company.Colspan = 2;
                for_company.HorizontalAlignment = Element.ALIGN_RIGHT;
                for_company.BorderWidthTop = 0;
                for_company.BorderWidthLeft = 0;
                for_company.BorderWidthBottom = 0;
                footer.AddCell(for_company);
                //row 4



                PdfPCell cus_sign = new PdfPCell(new Phrase("Customer Signature", smallfont));
                cus_sign.Colspan = 2;
                cus_sign.VerticalAlignment = Element.ALIGN_BOTTOM;
               // cus_sign.BorderWidthTop = 0;
                cus_sign.BorderWidthBottom = 0;
                //cus_sign.BorderWidthRight = 1;
                cus_sign.PaddingBottom = 5;
                footer.AddCell(cus_sign);

                PdfPCell auth_sign = new PdfPCell(new Phrase("Authorized signatory", smallfont));
                auth_sign.Colspan = 2;
                auth_sign.PaddingTop = 30;
                auth_sign.HorizontalAlignment = Element.ALIGN_RIGHT;
                auth_sign.BorderWidthLeft = 0;
                auth_sign.BorderWidthTop = 0;

                auth_sign.PaddingBottom = 5;
                footer.AddCell(auth_sign);

                //row
                PdfPCell disclaimer = new PdfPCell(new Phrase("  ", smallfont));
                disclaimer.Colspan = 4;
                footer.AddCell(disclaimer);



                footer.SplitLate = false;
                footer.SplitRows = true;
                document.Add(footer);
            }
            if (dt.Rows.Count > 0)
            {

                //PdfPTable bank_detail = new PdfPTable(2);
                //bank_detail.TotalWidth = 230f;
                //bank_detail.LockedWidth = true;
                ////bank_detail.KeepTogether = true;
                //bank_detail.HorizontalAlignment = Element.ALIGN_LEFT;

                //PdfPCell empty_headr = new PdfPCell(new Phrase(" "));
                //empty_headr.Colspan = 2;
                //empty_headr.BorderWidth = 0;
                //bank_detail.AddCell(empty_headr);

                //PdfPCell header = new PdfPCell(new Phrase("Banking/Payment instruction for Cheque/NEFT/RTGS/IMPS", address_font));
                //header.Colspan = 2;
                //bank_detail.AddCell(header);

                //PdfPCell ac_name = new PdfPCell(new Phrase("Account Name", address_font));
                //bank_detail.AddCell(ac_name);
                //PdfPCell account_name = new PdfPCell(new Phrase(dt.Rows[0]["account_name"].ToString(), address_font));
                //bank_detail.AddCell(account_name);

                //PdfPCell ac_no = new PdfPCell(new Phrase("Account Number", address_font));
                //bank_detail.AddCell(ac_no);
                //PdfPCell account_no = new PdfPCell(new Phrase(dt.Rows[0]["acc_no"].ToString(), address_font));
                //bank_detail.AddCell(account_no);

                //PdfPCell bank_name = new PdfPCell(new Phrase("Bank Name", address_font));
                //bank_detail.AddCell(bank_name);
                //PdfPCell bank_nam = new PdfPCell(new Phrase(dt.Rows[0]["bank_name"].ToString(), address_font));
                //bank_detail.AddCell(bank_nam);

                //PdfPCell branch_name = new PdfPCell(new Phrase("Bank Branch", address_font));
                //bank_detail.AddCell(branch_name);
                //PdfPCell br_name = new PdfPCell(new Phrase(dt.Rows[0]["bank_branch"].ToString(), address_font));
                //bank_detail.AddCell(br_name);

                //PdfPCell ifsc = new PdfPCell(new Phrase("IFSC", address_font));
                //bank_detail.AddCell(ifsc);
                //PdfPCell ifsc_code = new PdfPCell(new Phrase(dt.Rows[0]["ifsc"].ToString(), address_font));
                //bank_detail.AddCell(ifsc_code);

                //PdfPCell micr = new PdfPCell(new Phrase("MICR", address_font));
                //bank_detail.AddCell(micr);
                //PdfPCell micr_code = new PdfPCell(new Phrase(dt.Rows[0]["micr"].ToString(), address_font));
                //bank_detail.AddCell(micr_code);
                //bank_detail.SplitLate = false;
                //bank_detail.SplitRows = true;
                //document.Add(bank_detail);

            }

            document.Close();
            System.Diagnostics.Process.Start(newPath);
        }
    }
}
