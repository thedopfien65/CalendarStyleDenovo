function toggleMobileElements(ele1, ele2, class1, class2){
	$(ele1).addClass(class1);
	$(ele2).removeClass(class2);
}	

function clearScreenMobile(){
	$("#lt-timeslot-list-mobile").addClass("lt-mobile-hide");
	$("#lt-appt-details").addClass("lt-mobile-hide");
}

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
		initialDate: '2022-05-12',
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
		eventClick: function (d) {
			toggleMobileElements("#lt-dash-calendar-display", "#tech-dash-todays-appts", "lt-mobile-hide", "lt-desktop-hide");
		},
		eventDisplay: 'block',
		events: [{
			"title": "3 Appoinments",
			"start": "2022-06-11T10:00:00"
		}, {
			"title": "1 Appointment",
			"start": "2022-06-12T10:00:00"
		}, {
			"title": "4 Appointments",
			"start": "2022-06-12T11:00:00"
		}, {
			"title": "1 Appointment",
			"start": "2022-06-12T13:00:00"
		}, {
			"title": "1 Appointment",
			"start": "2022-06-12T14:00:00"
		}, {
			"title": "2 Appointments",
			"start": "2022-06-12T16:00:00"
		}, {
			"title": "1 Appointment",
			"start": "2022-06-13T12:00:00"
		}],
	});
	calendar.render();
	console.log(calendar.getEvents());
}

	
//mobile view tab controls
function mobileTabChange(elementID, controlID) {
	clearScreenMobile();
	$(elementID).removeClass("lt-mobile-hide");
	$(controlID).addClass("mtc-active");			
}

//reset tabs
function clearTabControlsTech(){
	$('#lt-dash-calendar-display').addClass('lt-mobile-hide');
	$('#tech-appointment-details').addClass('lt-mobile-hide');
	$('#tech-dash-todays-appts').addClass('lt-mobile-hide');
	$('#tech-dash-upcoming-assignments').addClass('lt-mobile-hide');			
	$('#mtc-tech-overview').removeClass('mtc-active');
	$('#mtc-today').removeClass('mtc-active');
	$('#mtc-upcoming').removeClass('mtc-active');
}

function initTechScheduleView() {
	//controls for tech schedule view
	$(document).ready(function () {
		$('#mtc-tech-overview').on('click', function () {
			clearTabControlsTech();
			mobileTabChange('#lt-dash-calendar-display', '#mtc-tech-overview');
		});

		$('#mtc-today').on('click', function () {
			clearTabControlsTech();
			mobileTabChange('#tech-dash-todays-appts', '#mtc-today');
		});

		$('#mtc-upcoming').on('click', function () {
			clearTabControlsTech();
			mobileTabChange('#tech-dash-upcoming-assignments', '#mtc-upcoming');
		});

		//activate button when option is selected
		$(".lt-pending-reassign-display").on('focus', function () {
			$('#reassign-appt').prop("disabled", false);
		});

		$(".lt-team-member-display").on('focus', function () {
			$('#view-tech-schedule').prop("disabled", false);
		});

		//forward-back controls for navigation of overview (peasant tech view)
		$(".td-button-today-mobile").on("click", function () {
			toggleMobileElements("#tech-dash-todays-appts", "#tech-appointment-details", "lt-desktop-hide", "lt-mobile-hide");
		});

		$("#todays-appts-back-btn").on("click", function () {
			toggleMobileElements("#tech-dash-todays-appts", "#lt-tech-calendar-display", "lt-mobile-hide", "lt-desktop-hide");
		});

		$("#tech-details-back-btn").on("click", function () {
			toggleMobileElements("#tech-dash-todays-appts", "#tech-appointment-details", "lt-desktop-hide", "lt-mobile-hide");
		});
	});
}