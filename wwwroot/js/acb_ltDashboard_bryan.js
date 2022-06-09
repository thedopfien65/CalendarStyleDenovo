function toggleMobileElements(ele1, ele2, class1, class2){
	$(ele1).addClass(class1);
	$(ele2).removeClass(class2);
}	
		
function clearScreenMobile(){
	$("#lt-timeslot-list-mobile").addClass("lt-mobile-hide");
	$("#lt-appt-details").addClass("lt-mobile-hide");
}

function addCallsForAppts() {
	//AJAX calls for updating appointment info
	$('.lt-tech-appointment-button').on('click', function () {
		var appointmentId = $(this).data('appt-id');
		$.ajax({
			url: "/App/GetAppointmentData/" + appointmentId,
			type: "GET",
			dataType: "json",
		})
			.done(function (json) {
				var apptTime = new Date(json.Timeslot);
				document.getElementById('lt-dash-appt-time').innerHTML = apptTime.toLocaleDateString("en-US", { hour: 'numeric', hour12: true });
				document.getElementById('lt-dash-appt-assignee').innerHTML = json.Assignee;

				document.getElementById('dash-client-name').innerHTML = json.ClientName;
				document.getElementById('dash-client-address').innerHTML = json.ClientAddr;
				document.getElementById('dash-client-note').innerHTML = "Note: " + json.Note;
				document.getElementById('lt-dash-equipment').innerHTML = '';

				for (i = 0; i < json.Equipment.length; i++) {
					var newEquip = document.createElement('li');
					newEquip.className = "lt-dash-equipment-item";
					newEquip.innerHTML = json.Equipment[i];
					document.getElementById('lt-dash-equipment').appendChild(newEquip);
				}
			})
			.fail(function (xhr, status, errorThrown) {
				console.log("Error: " + errorThrown);
				console.log("Status: " + status);
				console.dir(xhr);
			})
	});
}

function dateClickHandler(d) {
	//console.log(d.date);
	//alert("ajax call to grab day appointments");
	$.ajax({
		url: '/App/GetDateAppointments/' + d.date,
		type: "GET",
		dataType: "JSON",
	}).done(function (json) {
		var d = new Date(json.Day);
		document.getElementById('task-list-title-text').innerHTML = d.toLocaleDateString();

		document.getElementById('lt-dash-day-timeslot-list').innerHTML = "";

		for (var i = 0; i < json.Timeslots.length; i++) {
			//create outer div
			var newTimeslot = document.createElement('div');
			newTimeslot.classList = "lt-timeslot-display";

			//create toggle button
			var newTimeslotButton = document.createElement('button');
			newTimeslotButton.classList = 'btn btn-primary timeslot-detail-button';
			newTimeslotButton.setAttribute("type", "button");
			newTimeslotButton.setAttribute("data-bs-toggle", "collapse");
			newTimeslotButton.setAttribute("data-bs-target", "#timeslot-collapse-" + (i + 1));
			newTimeslotButton.innerHTML = json.Timeslots[i].Time;

			//create container for timeslot appointments
			var newTimeslotHolder = document.createElement('div');
			newTimeslotHolder.classList = "collapse lt-timeslot-techs-colapse";
			newTimeslotHolder.setAttribute("id", "timeslot-collapse-" + (i + 1));

			for (var j = 0; j < json.Timeslots[i].Appointments.length; j++) {
				var newTimeslotAppt = document.createElement('div');
				newTimeslotAppt.classList = "lt-tech-appointment-button";
				newTimeslotAppt.setAttribute("data-appt-id", json.Timeslots[i].Appointments[j].Id);

				var buttonLabelString = json.Timeslots[i].Appointments[j].Assignee + " | " + json.Timeslots[i].Appointments[j].ClientName + " | " + json.Timeslots[i].Appointments[j].ClientAddr;
				newTimeslotAppt.innerHTML = buttonLabelString;

				newTimeslotHolder.appendChild(newTimeslotAppt);
			}

			newTimeslot.appendChild(newTimeslotButton);
			newTimeslot.appendChild(newTimeslotHolder);
			document.getElementById('lt-dash-day-timeslot-list').appendChild(newTimeslot);
		}
		addCallsForAppts();

	}).fail(function (xhr, status, errorThrown) {
		console.log("Error: " + errorThrown);
		console.log("Status: " + status);
		console.dir(xhr);
	})
}

function initCalendar() {
	//initialize calendar, passing in options and event information
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
				dateClickHandler(d);
			},
			eventClick: function (d) {
				toggleMobileElements("#lt-dash-calendar-display", "#lt-timeslot-list-mobile", "lt-mobile-hide", "lt-desktop-hide");
			},
			eventDisplay: 'block',
			events: function (fetchInfo, successCallback, failureCallback) {
				$.ajax({
					url: '/App/GetCalendarData',
					type: "GET",
					dataType: "JSON",

					success: function (result) {
						var events = [];
						$.each(result, function (i, data) {
							events.push({
								id: data.id,
								title: data.title,
								start: data.start
							});
						});
						debugger;
						successCallback(events);
						console.log(calendar.getEvents());
					}
				});
			}
		});
	console.log(calendar.getEvents());
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
function clearTabControls(){
	$('#lt-dash-calendar-display').addClass('lt-mobile-hide');
	$('#lt-team-list').addClass('lt-mobile-hide');
	$('#lt-pending-assignments').addClass('lt-mobile-hide');			
	$('#mtc-overview').removeClass('mtc-active');
	$('#mtc-reassign').removeClass('mtc-active');
	$('#mtc-techs').removeClass('mtc-active');
}

function initLeadTechView() {
		$('#mtc-overview').on('click', function () {
			clearTabControls();
			mobileTabChange('#lt-dash-calendar-display', '#mtc-overview');
		});
		$('#mtc-reassign').on('click', function () {
			clearTabControls();
			mobileTabChange('#lt-pending-assignments', '#mtc-reassign');
		});
		$('#mtc-techs').on('click', function () {
			clearTabControls();
			mobileTabChange('#lt-team-list', '#mtc-techs');
		});

		//activate button when option is selected
		$(".lt-pending-reassign-display").on('focus', function () {
			$('#reassign-appt').prop("disabled", false);
		});

		$(".lt-team-member-display").on('focus', function () {
			$('#view-tech-schedule').prop("disabled", false);
		});

		//forward-back controls for navigation of overview (lead tech)
		$(".timeslot-detail-button-mobile").on("click", function () {
			toggleMobileElements("#lt-timeslot-list-mobile", "#lt-appt-details", "lt-desktop-hide", "lt-mobile-hide");
		});

		$("#appt-detail-back-btn").on("click", function () {
			toggleMobileElements("#lt-appt-details", "#lt-timeslot-list-mobile", "lt-mobile-hide", "lt-desktop-hide");
		});

		$("#timeslot-display-back-btn").on("click", function () {
			toggleMobileElements("#lt-timeslot-list-mobile", "#lt-dash-calendar-display", "lt-desktop-hide", "lt-mobile-hide");
		});

	addCallsForAppts();
}