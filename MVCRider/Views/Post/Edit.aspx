<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCRiderModel.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Post</legend>

        <%: Html.HiddenFor(model => model.ID) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Title) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Title) %>
            <%: Html.ValidationMessageFor(model => model.Title) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Body) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Body) %>
            <%: Html.ValidationMessageFor(model => model.Body) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Active) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Active) %>
            <%: Html.ValidationMessageFor(model => model.Active) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CreatedDate) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CreatedDate) %>
            <%: Html.ValidationMessageFor(model => model.CreatedDate) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

