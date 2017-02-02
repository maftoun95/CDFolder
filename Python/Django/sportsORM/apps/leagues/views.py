from django.shortcuts import render, redirect
from .models import League, Team, Player
from django.db.models import Q, Count
from . import team_maker


def index(request):
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 1
	# context = {
	# 	"leagues": League.objects.all().filter(sport="Baseball"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 2
	# context = {
	# 	"leagues": League.objects.all().filter(name__contains="Women"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 3
	# context = {
	# 	"leagues": League.objects.all().filter(sport__contains="Hockey"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 4
	# context = {
	# 	"leagues": League.objects.all().exclude(name__contains="Football"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 5
	# context = {
	# 	"leagues": League.objects.all().filter(name__contains="Conference"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 6
	# context = {
	# 	"leagues": League.objects.all().filter(name__contains="Atlantic"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 7
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(location="Dallas"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 8
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(team_name="Raptors"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 9
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(location__contains="City"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 10
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(team_name__startswith="T"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 11
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().order_by("team_name"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 12
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().order_by("-team_name"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 13
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(last_name="Cooper"),
	# }
	#NUMBER 14
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(first_name="Joshua"),
	# }
	#NUMBER 15
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(last_name="Cooper").exclude(first_name="Joshua"),
	# }
	#NUMBER 16
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(Q(first_name="Alexander")|Q(first_name="Wyatt")),
	# }
###############################################
	#NUMBER 1
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(league__name="Atlantic Soccer Conference"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 2
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(curr_team__team_name="Penguins"),
	# }
	#NUMBER 3
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(curr_team__league__name="International Collegiate Baseball Conference"),
	# }
	#NUMBER 4
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(curr_team__league__name="American Conference of Amateur Football").filter(last_name="Lopez"),
	# }
	#NUMBER 5
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(curr_team__league__sport="Football"),
	# }
	#NUMBER 6
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(curr_players__first_name="Sophia"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 7
	# context = {
	# 	"leagues": League.objects.all().filter(teams__curr_players__first_name="Sophia"),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 8
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(last_name="Flores").exclude(curr_team__team_name="Roughriders"),
	# }
	#############################################
	#NUMBER 1
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(Q(all_players__first_name="Samuel")&Q(all_players__last_name="Evans")),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 2
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(all_teams__team_name="Tiger-Cats"),
	# }
	#NUMBER 3
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
	# 	"players": Player.objects.all().filter(all_teams__team_name="Vikings").exclude(curr_team__team_name="Vikings"),
	# }
	#NUMBER 4
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all().filter(Q(all_players__first_name="Jacob")&Q(all_players__last_name="Gray")).exclude(team_name="Colts"),
	# 	"players": Player.objects.all(),
	# }
	#NUMBER 5
	# context = {
	# 	"leagues": League.objects.all(),
	# 	"teams": Team.objects.all(),
		"players": Player.objects.all().filter(first_name="Joshua").filter(all_teams__league__name="Atlantic Federation of Amateur Baseball Players"),
	# }
	#NUMBER 6
	fixed = Team.objects.annotate(Count('all_players'))
	print fixed[5].
	context = {
		"leagues": League.objects.all(),
		"teams": Team.objects.all(),
		"players": Player.objects.all(),
	}

	return render(request, "leagues/index.html", context)

def make_data(request):
	team_maker.gen_leagues(10)
	team_maker.gen_teams(50)
	team_maker.gen_players(200)

	return redirect("index")