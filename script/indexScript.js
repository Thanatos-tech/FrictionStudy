<script language="javascript">
	function tosmall()
	{
		var d=document
		var w=d.p1.width
		if (w>500)
		{d.p1.width= w-10
		d.p1.src="images/Ustanovka.png"
		setTimeout("tosmall()",5)}
	}
	function tobig()
	{	var d=document
		var w=d.p1.width
		if (w<800)
		{d.p1.width= w+10
		d.p1.src="images/Ustanovka.png"
		setTimeout("tobig()",5)}
	}
</script>