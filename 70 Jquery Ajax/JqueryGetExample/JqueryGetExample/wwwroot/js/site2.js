
        $(document).ready(function () {
            $("#loadProductsButton").click(function () {
                var searchTerm = $("#searchTerm").val();

                $.ajax({
                    type: "GET",
                    url: "Product/GetProducts",
                    data: { searchTerm: searchTerm },
                    success: function (response) {
                        let html = "<table>";
                        response.forEach(function (product) {
                            html += `<tr> <td>${product.name}</td> <td>${product.price}</td> </tr>`;
                        });
                        html += "</table>";
                        $("#productList").html(html);

                        },
                    error: function (xhr, status, error) {
                        $("#productList").text("Error: " + error);
                    }
                });
            });
        });
    


