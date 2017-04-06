<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8" />
	<title>{Title}</title>
</head>
<body>
	<script type="text/javascript" src="{~}/node_modules/vue/dist/vue.min.js"></script>

	<div id="app">
		{{message}}
	</div>

	<script>
		var v = new Vue({
			el: '#app',
			data: {
				message: 'Hello Vue.js!'
			}
		})
	</script>
</body>
</html>