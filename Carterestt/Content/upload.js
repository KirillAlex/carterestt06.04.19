(function ($, window, document, undefined) {

    var inputBox = $(".input-box");
    console.log(inputBox);

    function uploadFile(file) {
        $(file[0].files).each(function (index, element) {
            var ajaxData = new FormData();
            ajaxData.append("file", element);
            $.ajax(
                {
                    url: "/Upload",
                    type: "post",
                    data: ajaxData,
                    dataType: 'json',
                    cache: false,
                    contentType: false,
                    processData: false,
                    complete: function (data) {
                        data = JSON.parse(data.responseText);
                        if (data.status === "Success") {
                            $("#image-preview").html("<img src='/images/" + data.fileName + "' alt='' />");
                            $("input[name='FileName']").val(data.fileName);
                        } else {
                            alert(data.message);
                        }
                    },
                    error: function () {
                        alert('Error. Please, contact the webmaster!');
                    }
                });

        });
    }

    inputBox.change(function () {
        console.log("changed");
        uploadFile(inputBox);
    });
    /*
    */
})(jQuery, window, document);