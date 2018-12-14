<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<script src="js/jquery-3.2.1.min.js"></script>
<script>
function Add(){
	$("#hide2").val(1);
};
</script>

<script>
function Remove(stt){
	$("#hide2").val(2);
	$("#hide3").val(stt);
};
</script>
</head>
<body>
<form action="EditTest" method="get">
	<input type="hidden" id="hide1" name="testid" value=<%=request.getAttribute("testid")%>>
	<input type="hidden" id="hide2" name="action">
	<input type="hidden" id="hide3" name="stt">
	<label>Thêm câu hỏi</label><br>
	Mã môn học <input type="text" name="courseid"> Mã câu hỏi<input type="text" name="questionid"><button onclick="Add()">Lưu</button>
	${table}
</form>
</body>
</html>