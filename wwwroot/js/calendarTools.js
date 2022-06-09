function initCalendar() {

	var calViewButtons, calDefaultView;
	var screenSize = window.innerWidth;

	//set calendar defaults according to screen size			
	if (screenSize < 530) {
		calViewButtons = '';
		calDefaultView = "listWeek";
	} else {
		calViewButtons = 'dayGridMonth,listWeek';
		calDefaultView = "dayGridMonth";
	}

	var calendarEl = document.getElementById('calendar');
	var calendar = new FullCalendar.Calendar(calendarEl, {
		headerToolbar: {
			left: 'today',
			center: 'prev,title,next',
			right: calViewButtons,
		},
		buttonText: {
			dayGridMonth: 'Month',
			listWeek: 'Week',
			today: 'Today'
		},
		contentHeight: 'auto',
		initialView: calDefaultView,
		navLinks: true, // can click day/week names to navigate views
		selectable: true,
		nowIndicator: true,
		dayMaxEvents: true, // allow "more" link when too many events
		editable: true,
		selectable: true,
		businessHours: true,
		dayMaxEvents: true, // allow "more" link when too many events
		dateClick: function (d) {
			alert("date clicked");
		},
		eventDisplay: 'block',
		events: '/Home/GetCalendarData',
	});
	calendar.render();
	console.log(calendar.getEvents());
}