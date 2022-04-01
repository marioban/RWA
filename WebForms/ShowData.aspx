<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ShowData.aspx.cs" Inherits="WebForms.ShowData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/showData.css" rel="stylesheet" />

    <script>
        window.addEventListener('DOMContentLoaded', () => {
            const inputs = document.querySelectorAll('input[type=text]');
            const td = document.querySelectorAll('td');

            td.forEach(cell => cell.classList.add('align-middle'));
            inputs.forEach(input => input.classList.add('form-control'));


        });

    </script>

</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="container rounded shadowrealm">
        <div class="row">
            <h3 style="padding: 0.3em; margin: 0">Filtriraj podatke</h3>

        </div>
    </div>
    
    

    <div class="row mt-3">
        <div class="col-md-4 px-5">
            <div class="row d-flex justify-content-center text-center">
                <span style="font-weight: bold; font-size: 0.9em">Država</span>
            </div>
            <div class="row d-flex justify-content-center text-center">

                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="Naziv" DataValueField="IDDrzava">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksOBPConnectionString2 %>" SelectCommand="SELECT * FROM [Drzava]"></asp:SqlDataSource>

                </div>
        </div>


        <div class="col-md-4 px-5">
            <div class="row d-flex justify-content-center text-center">
                <span style="font-weight: bold; font-size: 0.9em">Grad</span>
            </div>

            <div class="row d-flex justify-content-center text-center">

                
                <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="Naziv" DataValueField="IDGrad">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksOBPConnectionString2 %>" SelectCommand="SELECT * FROM [Grad] WHERE ([DrzavaID] = @DrzavaID)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" PropertyName="SelectedValue" Name="DrzavaID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>

                
            </div>
        </div>

        <div class="col-md-4 px-5">
            <div class="row d-flex justify-content-center text-center">
                <span style="font-weight: bold; font-size: 0.9em">Stavke po stranici</span>
            </div>
            <div class="row d-flex justify-content-center text-center">
              
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control" AutoPostBack="True">
                    <asp:ListItem Enabled="True" Value="-1">Odaberite</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                </asp:DropDownList>
              
            </div>
        </div>

    </div>

    <div class="row">
        <div class="col-md-12 mt-5">
            <div class="row">
                <div class="col-md-12 mt-5">

                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />





                <div class="container">

                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CssClass="table table-light" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="IDKupac" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:CommandField ShowEditButton="True" />
                            <asp:TemplateField ShowHeader="False">
                            </asp:TemplateField>
                            <asp:BoundField DataField="IDKupac" HeaderText="IDKupac" ReadOnly="True" SortExpression="IDKupac" />
                            <asp:TemplateField HeaderText="Ime" SortExpression="Ime">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Ime") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ime") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Prezime" SortExpression="Prezime">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Prezime") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Prezime") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email" SortExpression="Email">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Telefon" SortExpression="Telefon">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Telefon") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Telefon") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="GradID" SortExpression="GradID">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("GradID") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("GradID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        <PagerStyle BorderColor="Transparent" BorderStyle="None" Font-Underline="true" />

                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:AdventureWorksOBPConnectionString2 %>" DeleteCommand="DELETE FROM [Kupac] WHERE [IDKupac] = @original_IDKupac AND [Ime] = @original_Ime AND [Prezime] = @original_Prezime AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND (([Telefon] = @original_Telefon) OR ([Telefon] IS NULL AND @original_Telefon IS NULL)) AND (([GradID] = @original_GradID) OR ([GradID] IS NULL AND @original_GradID IS NULL))" InsertCommand="INSERT INTO [Kupac] ([Ime], [Prezime], [Email], [Telefon], [GradID]) VALUES (@Ime, @Prezime, @Email, @Telefon, @GradID)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT IDKupac, Ime, Prezime, Email, Telefon, GradID FROM Kupac WHERE (GradID = @GradID)" UpdateCommand="UPDATE [Kupac] SET [Ime] = @Ime, [Prezime] = @Prezime, [Email] = @Email, [Telefon] = @Telefon, [GradID] = @GradID WHERE [IDKupac] = @original_IDKupac AND [Ime] = @original_Ime AND [Prezime] = @original_Prezime AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND (([Telefon] = @original_Telefon) OR ([Telefon] IS NULL AND @original_Telefon IS NULL)) AND (([GradID] = @original_GradID) OR ([GradID] IS NULL AND @original_GradID IS NULL))">
                        <DeleteParameters>
                            <asp:Parameter Name="original_IDKupac" Type="Int32" />
                            <asp:Parameter Name="original_Ime" Type="String" />
                            <asp:Parameter Name="original_Prezime" Type="String" />
                            <asp:Parameter Name="original_Email" Type="String" />
                            <asp:Parameter Name="original_Telefon" Type="String" />
                            <asp:Parameter Name="original_GradID" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Ime" Type="String" />
                            <asp:Parameter Name="Prezime" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Telefon" Type="String" />
                            <asp:Parameter Name="GradID" Type="Int32" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="GradID" PropertyName="SelectedValue" Type="Int32"/>
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Ime" Type="String" />
                            <asp:Parameter Name="Prezime" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Telefon" Type="String" />
                            <asp:Parameter Name="GradID" Type="Int32" />
                            <asp:Parameter Name="original_IDKupac" Type="Int32" />
                            <asp:Parameter Name="original_Ime" Type="String" />
                            <asp:Parameter Name="original_Prezime" Type="String" />
                            <asp:Parameter Name="original_Email" Type="String" />
                            <asp:Parameter Name="original_Telefon" Type="String" />
                            <asp:Parameter Name="original_GradID" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>

                    <br/>
                    <br/>

                </div>


                </div>
                
            </div>
        </div>
    </div>



</asp:Content>

