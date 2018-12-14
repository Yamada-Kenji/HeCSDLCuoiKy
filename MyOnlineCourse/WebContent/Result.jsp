<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<script>
function myFunction() {
    window.print();
}
</script>
</head>
<body>
<form action="Home.jsp">
	Tên bài kiểm tra:<%=request.getAttribute("title") %><br>
	Tên thí sinh:<%=request.getAttribute("username") %><br>
	Lớp:<%=request.getAttribute("classname") %><br>
	Điểm của bạn:<%=request.getAttribute("point") %><br>
	<button onclick="myFunction()">In kết quả</button><br>
	<a href="Home.jsp"><button>Trang chủ</button></a>
</form>
</body>
</html>