"use strict";

import { config } from "../../config";
import { app } from "../../server";

export function login() {
	app.get("/login", function(request, response) {
		response.render("pages/login", {
			"home": "localhost:" + config.get("port")
		});
	});
}
